﻿namespace WindowsForms
{
	partial class Login
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnGiris = new System.Windows.Forms.Button();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnGiris);
			this.groupBox1.Controls.Add(this.txtSifre);
			this.groupBox1.Controls.Add(this.txtKullaniciAdi);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(156, 107);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(235, 151);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kullanıcı Bilgileri";
			// 
			// btnGiris
			// 
			this.btnGiris.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.btnGiris.Location = new System.Drawing.Point(119, 115);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(100, 30);
			this.btnGiris.TabIndex = 4;
			this.btnGiris.Text = "Giriş Yap";
			this.btnGiris.UseVisualStyleBackColor = false;
			// 
			// txtSifre
			// 
			this.txtSifre.Location = new System.Drawing.Point(119, 72);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(100, 22);
			this.txtSifre.TabIndex = 3;
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Location = new System.Drawing.Point(119, 44);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 22);
			this.txtKullaniciAdi.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Şifre";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kullanıcı Adı";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(557, 450);
			this.Controls.Add(this.groupBox1);
			this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Name = "Login";
			this.Text = "Login";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnGiris;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.TextBox txtKullaniciAdi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}