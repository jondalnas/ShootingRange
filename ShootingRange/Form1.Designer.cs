namespace ShootingRange {
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
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.listView1 = new System.Windows.Forms.ListView();
			this.Voltage = new System.Windows.Forms.TextBox();
			this.Readvolt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(128, 147);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(121, 97);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// Voltage
			// 
			this.Voltage.Location = new System.Drawing.Point(466, 187);
			this.Voltage.Name = "Voltage";
			this.Voltage.Size = new System.Drawing.Size(100, 20);
			this.Voltage.TabIndex = 1;
			// 
			// Readvolt
			// 
			this.Readvolt.Location = new System.Drawing.Point(466, 221);
			this.Readvolt.Name = "Readvolt";
			this.Readvolt.Size = new System.Drawing.Size(100, 23);
			this.Readvolt.TabIndex = 3;
			this.Readvolt.Text = "Read voltage";
			this.Readvolt.UseVisualStyleBackColor = true;
			this.Readvolt.Click += new System.EventHandler(this.Readvolt_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Readvolt);
			this.Controls.Add(this.Voltage);
			this.Controls.Add(this.listView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.TextBox Voltage;
		private System.Windows.Forms.Button Readvolt;
	}
}

