﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.Visa;
using Ivi.Visa;

namespace ShootingRange {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
			ResourceManager rm = new ResourceManager();

			foreach (string str in rm.Find("?*")) Console.WriteLine(str);
		}
	}
}
