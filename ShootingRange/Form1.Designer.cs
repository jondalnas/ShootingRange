﻿namespace ShootingRange {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			Controller.Dispose();

			Program.Dispose();

			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);

			NIController.Dispose();
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.distBtn = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.delBtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.stuckbtn = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.warning_label = new System.Windows.Forms.Label();
			this.stuckSymbol = new System.Windows.Forms.PictureBox();
			this.up = new System.Windows.Forms.PictureBox();
			this.standstill = new System.Windows.Forms.PictureBox();
			this.down = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.targetPosBar1 = new ShootingRange.TargetPosBar();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stuckSymbol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.up)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.standstill)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.down)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// distBtn
			// 
			this.distBtn.Location = new System.Drawing.Point(130, 327);
			this.distBtn.Name = "distBtn";
			this.distBtn.Size = new System.Drawing.Size(162, 23);
			this.distBtn.TabIndex = 2;
			this.distBtn.Text = "Go to distance";
			this.distBtn.UseVisualStyleBackColor = true;
			this.distBtn.Click += new System.EventHandler(this.distBtn_Click);
			// 
			// btn7
			// 
			this.btn7.Location = new System.Drawing.Point(130, 60);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(50, 50);
			this.btn7.TabIndex = 4;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = true;
			this.btn7.Click += new System.EventHandler(this.btn7_Click);
			// 
			// btn8
			// 
			this.btn8.Location = new System.Drawing.Point(186, 60);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(50, 50);
			this.btn8.TabIndex = 5;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = true;
			this.btn8.Click += new System.EventHandler(this.btn8_Click);
			// 
			// btn9
			// 
			this.btn9.Location = new System.Drawing.Point(242, 60);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(50, 50);
			this.btn9.TabIndex = 6;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = true;
			this.btn9.Click += new System.EventHandler(this.btn9_Click);
			// 
			// btn4
			// 
			this.btn4.Location = new System.Drawing.Point(130, 116);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(50, 50);
			this.btn4.TabIndex = 7;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = true;
			this.btn4.Click += new System.EventHandler(this.btn4_Click);
			// 
			// btn5
			// 
			this.btn5.Location = new System.Drawing.Point(186, 116);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(50, 50);
			this.btn5.TabIndex = 8;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = true;
			this.btn5.Click += new System.EventHandler(this.btn5_Click);
			// 
			// btn6
			// 
			this.btn6.Location = new System.Drawing.Point(242, 116);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(50, 50);
			this.btn6.TabIndex = 9;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = true;
			this.btn6.Click += new System.EventHandler(this.btn6_Click);
			// 
			// btn3
			// 
			this.btn3.Location = new System.Drawing.Point(242, 172);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(50, 50);
			this.btn3.TabIndex = 12;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.btn3_Click);
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(186, 172);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(50, 50);
			this.btn2.TabIndex = 11;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(130, 172);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(50, 50);
			this.btn1.TabIndex = 10;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			// 
			// btn0
			// 
			this.btn0.Location = new System.Drawing.Point(186, 228);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(50, 50);
			this.btn0.TabIndex = 13;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = true;
			this.btn0.Click += new System.EventHandler(this.btn0_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 396);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "0 m";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(752, 395);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "90 m";
			// 
			// delBtn
			// 
			this.delBtn.Location = new System.Drawing.Point(242, 228);
			this.delBtn.Name = "delBtn";
			this.delBtn.Size = new System.Drawing.Size(50, 50);
			this.delBtn.TabIndex = 17;
			this.delBtn.Text = "del";
			this.delBtn.UseVisualStyleBackColor = true;
			this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(298, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(245, 395);
			this.label3.TabIndex = 16;
			this.label3.Text = "0";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(6, 60);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar1.Size = new System.Drawing.Size(45, 290);
			this.trackBar1.TabIndex = 18;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 16);
			this.label4.TabIndex = 21;
			this.label4.Text = "Speed";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(130, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(162, 23);
			this.label5.TabIndex = 22;
			this.label5.Text = "Input wanted distance";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(686, 190);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(102, 32);
			this.label6.TabIndex = 24;
			this.label6.Text = "Current running status:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// stuckbtn
			// 
			this.stuckbtn.Location = new System.Drawing.Point(686, 143);
			this.stuckbtn.Name = "stuckbtn";
			this.stuckbtn.Size = new System.Drawing.Size(102, 23);
			this.stuckbtn.TabIndex = 25;
			this.stuckbtn.Text = "Emergency stop";
			this.stuckbtn.UseVisualStyleBackColor = true;
			this.stuckbtn.Click += new System.EventHandler(this.stuckbtn_Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(549, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 31;
			this.label7.Text = "Current direction";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// warning_label
			// 
			this.warning_label.BackColor = System.Drawing.SystemColors.Control;
			this.warning_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.warning_label.Location = new System.Drawing.Point(-5, 0);
			this.warning_label.Name = "warning_label";
			this.warning_label.Size = new System.Drawing.Size(809, 452);
			this.warning_label.TabIndex = 32;
			this.warning_label.Text = "Warning! Motor stuck! Fix error ";
			this.warning_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.warning_label.Visible = false;
			// 
			// stuckSymbol
			// 
			this.stuckSymbol.Cursor = System.Windows.Forms.Cursors.Default;
			this.stuckSymbol.Location = new System.Drawing.Point(686, 226);
			this.stuckSymbol.Name = "stuckSymbol";
			this.stuckSymbol.Size = new System.Drawing.Size(100, 100);
			this.stuckSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.stuckSymbol.TabIndex = 23;
			this.stuckSymbol.TabStop = false;
			// 
			// up
			// 
			this.up.Location = new System.Drawing.Point(570, 66);
			this.up.Name = "up";
			this.up.Size = new System.Drawing.Size(50, 50);
			this.up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.up.TabIndex = 28;
			this.up.TabStop = false;
			// 
			// standstill
			// 
			this.standstill.Location = new System.Drawing.Point(570, 122);
			this.standstill.Name = "standstill";
			this.standstill.Size = new System.Drawing.Size(50, 50);
			this.standstill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.standstill.TabIndex = 27;
			this.standstill.TabStop = false;
			// 
			// down
			// 
			this.down.Location = new System.Drawing.Point(570, 178);
			this.down.Name = "down";
			this.down.Size = new System.Drawing.Size(50, 50);
			this.down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.down.TabIndex = 26;
			this.down.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::ShootingRange.Properties.Resources.Rabbit_symbol;
			this.pictureBox2.Location = new System.Drawing.Point(44, 60);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(67, 50);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 20;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ShootingRange.Properties.Resources.Turtle_symbol1;
			this.pictureBox1.Location = new System.Drawing.Point(44, 305);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(67, 45);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			// 
			// targetPosBar1
			// 
			this.targetPosBar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.targetPosBar1.Location = new System.Drawing.Point(12, 415);
			this.targetPosBar1.Name = "targetPosBar1";
			this.targetPosBar1.Size = new System.Drawing.Size(776, 23);
			this.targetPosBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.targetPosBar1.TabIndex = 29;
			// 
			// Form1
			// 
			this.AcceptButton = this.distBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.stuckbtn);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.stuckSymbol);
			this.Controls.Add(this.warning_label);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.up);
			this.Controls.Add(this.standstill);
			this.Controls.Add(this.down);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.delBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.distBtn);
			this.Controls.Add(this.targetPosBar1);
			this.KeyPreview = true;
			this.Name = "Form1";
			this.Text = "Shooting Range Controller";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stuckSymbol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.up)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.standstill)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.down)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button distBtn;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button delBtn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox stuckSymbol;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button stuckbtn;
		private System.Windows.Forms.PictureBox down;
		private System.Windows.Forms.PictureBox standstill;
		private System.Windows.Forms.PictureBox up;
		private TargetPosBar targetPosBar1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label warning_label;
	}
}