using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ShootingRange {
	static class Program {
		static private Form1 mainForm;
		private static bool running = true, updateStart = false;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Controller.Initialize();
			
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-us");

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			mainForm = new Form1();

			Application.Idle += delegate{ if (updateStart) return; Task.Factory.StartNew(Update); updateStart = true; }; //Run update on different thread, when Form is done loading

			Application.Run(mainForm);
		}

		private static void Update() {
			while (running) {
				mainForm.UpdateForm();
				Controller.Update();
			}
		}

		public static void Dispose() {
			running = false;
		}
	}
}
