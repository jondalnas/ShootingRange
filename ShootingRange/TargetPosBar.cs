﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ShootingRange {
	public class TargetPosBar : ProgressBar {
		[DllImport("uxtheme.dll")]
		private static extern int SetWindowTheme(IntPtr hWnd, string appname, string idlist);

		protected override void OnHandleCreated(EventArgs e) {
			SetWindowTheme(this.Handle, "", "");
			base.OnHandleCreated(e);
		}
	}
}
