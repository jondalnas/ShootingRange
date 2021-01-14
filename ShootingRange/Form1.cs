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
		private static Image GREEN_LIGHT = global::ShootingRange.Properties.Resources.green_light, RED_LIGHT = global::ShootingRange.Properties.Resources.red_light, DOWN_ARROW = global::ShootingRange.Properties.Resources.Down_arrow, DOWN_ARROW_LIT = global::ShootingRange.Properties.Resources.Down_arrow_lit, UP_ARROW = global::ShootingRange.Properties.Resources.Up_arrow, UP_ARROW_LIT = global::ShootingRange.Properties.Resources.Up_arrow_lit, STANDSTIL = global::ShootingRange.Properties.Resources.standstill, STANDSTIL_LIT = global::ShootingRange.Properties.Resources.standstill_lit; // Preinitialize images to remove memory leak

		public byte dist;
		public bool fast;
		public bool stuck = false;
		private bool oldStuck = true; //!stuck
		private const float deadzone = 0.01f;
		public float direction = 2.5f;
		public byte oldDir;
		public bool warning;

		public Form1() {
			InitializeComponent();
			targetPosBar1.Maximum = 90;
			dist = 0;
			this.KeyPreview = true;
			this.KeyDown += new KeyEventHandler(Form1_KeyDown);

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
		}

		delegate void SetLabelCallBack();

		public void ChangeWarning() {
			SetLabelCallBack l = new SetLabelCallBack(SetWarning);
			Invoke(l);
			warning = !warning;
		}

		private void SetWarning() {
			warning_label.Visible = warning;
		}

		public void UpdateForm() {
			//Update graphic to moving direction
			//TODO: Update this
			if (direction < 2.5 - deadzone) {
				if (oldDir == 0) goto stck;

				oldDir = 0; //Zero is backwards
				up.Image = UP_ARROW;
				standstill.Image = STANDSTIL;
				down.Image = DOWN_ARROW_LIT;
			} else if (direction > 2.5 + deadzone) {
				if (oldDir == 2) goto stck;

				oldDir = 2; //Two is forwards
				up.Image = UP_ARROW_LIT;
				standstill.Image = STANDSTIL;
				down.Image = DOWN_ARROW;
			} else if(direction < 2.5 + deadzone && direction > 2.5 - deadzone) {
				if (oldDir == 1) goto stck;

				oldDir = 1; //One is standstil
				up.Image = UP_ARROW;
				standstill.Image = STANDSTIL_LIT;
				down.Image = DOWN_ARROW;
			}

			stck:

			//Update current distance to readings from Controller
			targetPosBar1.Value = Controller.GetDistance();

			//Check if motor is stuck and update Form accordingly
			//TODO: Update this, when we can read a stuck signal
			if (stuck == oldStuck) return;
			oldStuck = stuck;

			if (!stuck) {
				stuckSymbol.Image = GREEN_LIGHT;
				ChangeWarning();
			}
			if (stuck) {
				stuckSymbol.Image = RED_LIGHT;
				ChangeWarning();
			}
		}

		private void distBtn_Click(object sender, EventArgs e) {
			Controller.SetTargetDistance(dist);
			dist = 0;
		}

		private void btn7_Click(object sender, EventArgs e) {
			if (dist > 9) {
				dist = 90;
			} else {
				dist = (byte)(dist * 10 + 7);
			}
			this.label3.Text = dist + "";
		}

		private void btn8_Click(object sender, EventArgs e) {
			if (dist > 9) {
				dist = 90;
			} else {
				dist = (byte)(dist * 10 + 8);
			}
			this.label3.Text = dist + "";
		}

		private void btn9_Click(object sender, EventArgs e) {
			if (dist > 9) {
				dist = 90;
			} else {
				dist = (byte)(dist * 10 + 9);
			}
			this.label3.Text = dist + "";
		}

		private void btn4_Click(object sender, EventArgs e) {
			if (dist > 9) {
				dist = 90;
			} else {
				dist = (byte)(dist * 10 + 4);
			}
			this.label3.Text = dist + "";
		}

		private void btn5_Click(object sender, EventArgs e) {
			if (dist > 9) {
				dist = 90;
			} else {
				dist = (byte)(dist * 10 + 5);
			}
			this.label3.Text = dist + "";
		}

		private void btn6_Click(object sender, EventArgs e) {
			if (dist > 9) {
				dist = 90;
			} else {
				dist = (byte)(dist * 10 + 6);
			}
			this.label3.Text = dist + "";
		}

		private void btn3_Click(object sender, EventArgs e) {
			if (dist > 9) {
				dist = 90;
			} else {
				dist = (byte)(dist * 10 + 3);
			}
			this.label3.Text = dist + "";
		}


		private void btn2_Click(object sender, EventArgs e) {
			if (dist > 9) {
				dist = 90;
			} else {
				dist = (byte)(dist * 10 + 2);
			}
			this.label3.Text = dist + "";
		}

		private void btn1_Click(object sender, EventArgs e) {
			if (dist > 9) {
				dist = 90;
			} else {
				dist = (byte)(dist * 10 + 1);
			}
			this.label3.Text = dist + "";
		}

		private void btn0_Click(object sender, EventArgs e) {
			if (dist > 9) {
				dist = 90;
			} else {
				dist = (byte)(dist * 10);
			}
			this.label3.Text = dist + "";
		}

		private void delBtn_Click(object sender, EventArgs e) {
			dist = (byte) (dist / 10);
			this.label3.Text = dist + "";
		}


		private void trackBar1_Scroll(object sender, EventArgs e) {
			Controller.SetSpeed((byte) trackBar1.Value);
		}

		private void stuckbtn_Click(object sender, EventArgs e) {
			stuck = !stuck;
		}


		private void Form1_Load(object sender, EventArgs e) {

		}
	}
}