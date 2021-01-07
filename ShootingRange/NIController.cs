using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NationalInstruments.DAQmx;

namespace ShootingRange {
	class NIController {
		private static NationalInstruments.DAQmx.Task task;
		private static AIChannel motorLoad;
		private static AOChannel motorControl;
		public static void InitializeInstrument() {
			//Initializing Task
			task = new Task();

			//Initializing channels
			motorLoad = task.AIChannels.CreateCurrentChannel("dev1/ai0", "Motor Load Channel", AITerminalConfiguration.Rse, 0, 1, AICurrentUnits.Amps);
			motorControl = task.AOChannels.CreateVoltageChannel("dev1/ao0", "Motor Control Channel", -10,10,AOVoltageUnits.Volts);
		}

		public static double ReadCurrent() {
			AnalogSingleChannelReader reader = new AnalogSingleChannelReader(task.Stream);
			double current = reader.ReadSingleSample();
			return current;
		}
	}
}
