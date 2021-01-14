using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ShootingRange {
	static class Program {
		static private Form1 mainForm;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-us");

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			mainForm = new Form1();
			Task thread = new Task(Update);
			thread.Start();

			Application.Run(mainForm);
		}

		private static void Update() {
			while (true) {
				mainForm.UpdateForm();
			}
		}
	}
}
