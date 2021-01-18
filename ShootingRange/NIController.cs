using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NationalInstruments.DAQmx;

namespace ShootingRange {
	class NIController {
		private static NationalInstruments.DAQmx.Task motorLoadTask;
		private static NationalInstruments.DAQmx.Task motorControlTask;
		private static NationalInstruments.DAQmx.Task motorRotationsTask;
		private static AIChannel motorLoadChannel;
		private static AOChannel motorControlChannel;
		private static DIChannel motorRotationsChannel;

		private static bool disposed = false;

		public static void InitializeInstrument() {
			//Initializing Task
			motorLoadTask = new Task();
			motorControlTask = new Task();
			motorRotationsTask = new Task();

			//Initializing channels
			//Voltage analog in
			motorLoadChannel = motorLoadTask.AIChannels.CreateVoltageChannel("dev1/ai0", "Motor Load Channel", AITerminalConfiguration.Rse, 0, 10, AIVoltageUnits.Volts);

			//Voltage analog out
			motorControlChannel = motorControlTask.AOChannels.CreateVoltageChannel("dev1/ao0", "Motor Control Channel", 0, 5, AOVoltageUnits.Volts);

			//Voltage digital in
			motorRotationsChannel = motorRotationsTask.DIChannels.CreateChannel("dev1/port0", "Motor Rotation Channel", ChannelLineGrouping.OneChannelForAllLines);
		}

		public static void SetMotorControl(double voltage) {
			WriteAnalog(motorControlTask, voltage);
		}

		public static double GetMotorLoad() {
			return ReadAnalog(motorLoadTask);
		}

		//Digital signal is SRRRRRRR
		//S is stuck bit
		//R is distance
		public static byte GetRotations() {
			return (byte) (ReadDigital(motorRotationsTask) & 0b1111111);
		}

		public static bool IsStuck() {
			return (ReadDigital(motorRotationsTask) >> 7 & 1) == 1;
		}

		private static double ReadAnalog(Task task) {
			if (disposed) return 0;

			AnalogSingleChannelReader reader = new AnalogSingleChannelReader(task.Stream);
			double sample = reader.ReadSingleSample();
			return sample;
		}

		public static byte ReadDigital(Task task) {
			if (disposed) return 0;

			DigitalSingleChannelReader reader = new DigitalSingleChannelReader(task.Stream);
			byte sample = reader.ReadSingleSamplePortByte();
			return sample;
		}

		private static void WriteAnalog(Task task, double voltage) {
			if (disposed) return;

			AnalogSingleChannelWriter write = new AnalogSingleChannelWriter(task.Stream);
			write.BeginWriteSingleSample(true, voltage, null, null);
		}

		private static void WriteDigital(Task task, byte data) {
			if (disposed) return;

			//Convert byte into bool array
			bool[] boolData = new bool[sizeof(byte)];
			for (var i = 0; i < sizeof(byte); i++) {
				boolData[i] = (data & 1) == 1;
				data >>= 1;
			}

			WriteDigital(task, boolData);
		}

		private static void WriteDigital(Task task, bool[] data) {
			if (disposed) return;

			DigitalSingleChannelWriter write = new DigitalSingleChannelWriter(task.Stream);
			write.BeginWriteSingleSampleMultiLine(true, data, null, null);
		}

		public static void Dispose() {
			if (motorControlChannel == null) return;

			motorControlChannel.Dispose();
			motorLoadChannel.Dispose();
			motorRotationsChannel.Dispose();
			motorControlTask.Dispose();
			motorLoadTask.Dispose();
			motorRotationsTask.Dispose();

			disposed = true;
		}
	}
}
