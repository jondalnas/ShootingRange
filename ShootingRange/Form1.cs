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
		}

		private void Readvolt_Click(object sender, EventArgs e) {
			NIController.SetMotorControl(NIController.GetMotorLoad());
			listView1.Items.Clear();
			listView1.Items.Add(new ListViewItem(NIController.GetRotations() + ""));
		}
	}
}
