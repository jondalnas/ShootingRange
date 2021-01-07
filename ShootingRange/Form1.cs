using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.DAQmx;

namespace ShootingRange {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();

			foreach (string str in DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.All, PhysicalChannelAccess.External)) {
				listView1.Items.Add(new ListViewItem(str));
			}
			
		}

		private void Readvolt_Click(object sender, EventArgs e) {
			Task ai = new Task();
			AIChannel aic = ai.AIChannels.CreateVoltageChannel("Dev1/ai0", "AnalogVoltageChannel0", AITerminalConfiguration.Rse, 0, 10, AIVoltageUnits.Volts);
			AnalogSingleChannelReader reader = new AnalogSingleChannelReader(ai.Stream);
			double volt = reader.ReadSingleSample();
			Voltage.Text = volt.ToString("0.0");
			aic.Dispose();
		}
	}
}
