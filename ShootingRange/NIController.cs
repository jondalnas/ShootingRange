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
		private static DOChannel motorRotationsChannel;

		public static void InitializeInstrument() {
			//Initializing Task
			motorLoadTask = new Task();
			motorControlTask = new Task();
			motorRotationsTask = new Task();

			//Initializing channels
			//Voltage analog in
			motorLoadChannel = motorLoadTask.AIChannels.CreateVoltageChannel("dev1/ai0", "Motor Load Channel", AITerminalConfiguration.Rse, 0, 10, AIVoltageUnits.Volts);

			//Voltage analog out
			motorControlChannel = motorControlTask.AOChannels.CreateVoltageChannel("dev1/ao0", "Motor Control Channel", -10, 10, AOVoltageUnits.Volts);

			//Voltage digital in
			motorRotationsChannel = motorRotationsTask.DOChannels.CreateChannel("dev1/port0", "Motor Rotation Channel", ChannelLineGrouping.OneChannelForAllLines);
		}

		public static void SetMotorControl(double voltage) {
			//TODO: Add WriteVoltage(double) method
		}

		public static double GetMotorLoad() {
			return ReadVoltage(motorLoadTask);
		}

		public static byte GetRotations() {
			return ReadData(motorRotationsTask);
		}

		private static double ReadVoltage(Task task) {
			AnalogSingleChannelReader reader = new AnalogSingleChannelReader(task.Stream);
			double sample = reader.ReadSingleSample();
			return sample;
		}

		private static double ReadCurrent(Task task) {
			AnalogSingleChannelReader reader = new AnalogSingleChannelReader(task.Stream);
			double sample = reader.ReadSingleSample();
			return sample;
		}

		public static byte ReadData(Task task) {
			DigitalSingleChannelReader reader = new DigitalSingleChannelReader(task.Stream);
			byte sample = reader.ReadSingleSamplePortByte();
			return sample;
		}

		public static void Dispose() {
			motorControlChannel.Dispose();
			motorLoadChannel.Dispose();
			motorRotationsChannel.Dispose();
			motorControlTask.Dispose();
			motorLoadTask.Dispose();
			motorRotationsTask.Dispose();
		}
	}
}
