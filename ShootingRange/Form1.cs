using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace ShootingRange {
	public partial class Form1 : Form {
		private static Image GREEN_LIGHT = global::ShootingRange.Properties.Resources.green_light, RED_LIGHT = global::ShootingRange.Properties.Resources.red_light, DOWN_ARROW = global::ShootingRange.Properties.Resources.Down_arrow, DOWN_ARROW_LIT = global::ShootingRange.Properties.Resources.Down_arrow_lit, UP_ARROW = global::ShootingRange.Properties.Resources.Up_arrow, UP_ARROW_LIT = global::ShootingRange.Properties.Resources.Up_arrow_lit, STANDSTILL = global::ShootingRange.Properties.Resources.standstill, STANDSTILL_LIT = global::ShootingRange.Properties.Resources.standstill_lit; // Preinitialize images to remove memory leak

		public byte dist;
		public bool fast;
		private bool oldStuck = true; //!stuck
		private sbyte oldDir = 1; //Set to not zero, so graphic updates on startup
		public bool warning;

		public Form1() {
			InitializeComponent();
			targetPosBar1.Maximum = 90;
			dist = 0;
			this.AcceptButton = distBtn;
			this.KeyPreview = true;
			this.KeyDown += new KeyEventHandler(Form1_KeyDown);
			//this.KeyPress += new KeyPressEventHandler(Form1_KeyDown);

			up.Image = UP_ARROW;
			down.Image = DOWN_ARROW;
			standstill.Image = STANDSTILL;
		}

		public void Form1_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.D0) {
				btn0.PerformClick();
			}
			if (e.KeyCode == Keys.D1) {
				btn1.PerformClick();
			}
			if (e.KeyCode == Keys.D2) {
				btn2.PerformClick();
			}
			if (e.KeyCode == Keys.D3) {
				btn3.PerformClick();
			}
			if (e.KeyCode == Keys.D4) {
				btn4.PerformClick();
			}
			if (e.KeyCode == Keys.D5) {
				btn5.PerformClick();
			}
			if (e.KeyCode == Keys.D6) {
				btn6.PerformClick();
			}
			if (e.KeyCode == Keys.D7) {
				btn7.PerformClick();
			}
			if (e.KeyCode == Keys.D8) {
				btn8.PerformClick();
			}
			if (e.KeyCode == Keys.D9) {
				btn9.PerformClick();
			}
			if (e.KeyCode == Keys.Back) {
				delBtn.PerformClick();
			}
			if (e.KeyCode == Keys.Space) {
				distBtn.PerformClick();
			}
		}

		delegate void SetWarningLabelCallBack();

		public void ChangeWarning() {
			SetWarningLabelCallBack l = new SetWarningLabelCallBack(SetWarning);
			Invoke(l);
		}

		private void SetWarning() {
			bool stuck = Controller.IsStuck();
			warning_label.Visible = stuck;

			if (stuck) stuckbtn.Text = "Reset stuck";
			else stuckbtn.Text = "Emergency stop";
		}

		delegate void SetTargetPosBarValue(byte pos);

		private void SetTargetPos(byte pos) {
			if (pos > targetPosBar1.Maximum) pos = (byte)targetPosBar1.Maximum;

			targetPosBar1.Value = pos;
		}

		delegate void SetDirectionImages(ref Image up, ref Image down, ref Image still);

		private void SetDirection(ref Image up, ref Image down, ref Image still) {
			this.up.Image = up;
			this.down.Image = down;
			standstill.Image = still;
		}

		public void UpdateForm() {
			//Update graphic to moving direction
			SetDirectionImages di = new SetDirectionImages(SetDirection);
			switch (Controller.GetDirection()) {
				case -1:
					if (oldDir == -1) break;

					oldDir = -1; //-1 is backwards
					BeginInvoke(di, UP_ARROW, DOWN_ARROW_LIT, STANDSTILL);
					break;
				case 1:
					if (oldDir == 1) break;

					oldDir = 1; //1 is forwards
					BeginInvoke(di, UP_ARROW_LIT, DOWN_ARROW, STANDSTILL);
					break;
				case 0:
					if (oldDir == 0) break;

					oldDir = 0; //0 is standstil
					BeginInvoke(di, UP_ARROW, DOWN_ARROW, STANDSTILL_LIT);
					break;
			}

			//Update current distance to readings from Controller
			SetTargetPosBarValue tp = new SetTargetPosBarValue(SetTargetPos);
			
			BeginInvoke(tp, Controller.GetDistance());

			//Check if motor is stuck and update Form accordingly
			bool stuck = Controller.IsStuck();
			if (stuck == oldStuck) return;
			oldStuck = stuck;

			if (stuck) {
				stuckSymbol.Image = RED_LIGHT;
				ChangeWarning();
			} else {
				stuckSymbol.Image = GREEN_LIGHT;
				ChangeWarning();
			}
		}

		private void distBtn_Click(object sender, EventArgs e) {
			Controller.SetTargetDistance(dist);
			dist = 0;

			distBtn.Text = "Retrieve target";
			distBtn.Focus();
		}

		private void btn7_Click(object sender, EventArgs e) {
			AddNumber(7);
		}

		private void btn8_Click(object sender, EventArgs e) {
			AddNumber(8);
		}

		private void btn9_Click(object sender, EventArgs e) {
			AddNumber(9);
		}

		private void btn4_Click(object sender, EventArgs e) {
			AddNumber(4);
		}

		private void btn5_Click(object sender, EventArgs e) {
			AddNumber(5);
		}

		private void btn6_Click(object sender, EventArgs e) {
			AddNumber(6);
		}

		private void btn3_Click(object sender, EventArgs e) {
			AddNumber(3);
		}


		private void btn2_Click(object sender, EventArgs e) {
			AddNumber(2);
		}

		private void btn1_Click(object sender, EventArgs e) {
			AddNumber(1);
		}

		private void btn0_Click(object sender, EventArgs e) {
			AddNumber(0);
		}

		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		private void AddNumber(byte num) {
			if (dist > 9) {
				dist = 90;
			} else {
				dist = (byte)(dist * 10 + num);
			}
			this.label3.Text = dist + "";

			if (dist != 0) distBtn.Text = "Go to distance";
			else distBtn.Text = "Retrieve target";

			distBtn.Focus();
		}

		private void delBtn_Click(object sender, EventArgs e) {
			dist = (byte) (dist / 10);
			this.label3.Text = dist + "";

			if (dist != 0) distBtn.Text = "Go to distance";
			else distBtn.Text = "Retrieve target";

			distBtn.Focus();
		}

		private void trackBar1_Scroll(object sender, EventArgs e) {
			Controller.SetSpeed((byte) trackBar1.Value);
		}

		private void stuckbtn_Click(object sender, EventArgs e) {
			if (Controller.IsStuck()) Controller.ResetStuck();
			else Controller.SetStuck();

			distBtn.Focus();
		}


		private void Form1_Load(object sender, EventArgs e) {

		}
	}
}