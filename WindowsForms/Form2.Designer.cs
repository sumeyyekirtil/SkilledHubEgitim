﻿namespace WindowsForms
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblMesaj = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblMesaj
			// 
			this.lblMesaj.AutoSize = true;
			this.lblMesaj.Location = new System.Drawing.Point(31, 27);
			this.lblMesaj.Name = "lblMesaj";
			this.lblMesaj.Size = new System.Drawing.Size(87, 16);
			this.lblMesaj.TabIndex = 0;
			this.lblMesaj.Text = "Burası 2. form";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(34, 64);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 44);
			this.button1.TabIndex = 1;
			this.button1.Text = "Form 1 i aç";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(34, 135);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(84, 45);
			this.button2.TabIndex = 2;
			this.button2.Text = "Kapat";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(34, 203);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(102, 51);
			this.button3.TabIndex = 3;
			this.button3.Text = "Uygulamayı Kapat";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblMesaj);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMesaj;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}