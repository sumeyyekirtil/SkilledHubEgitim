namespace WindowsForms
{
	partial class Form5
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtFiyati = new System.Windows.Forms.TextBox();
			this.txtUrunAdi = new System.Windows.Forms.TextBox();
			this.txtMarkasi = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cbKategoriler = new System.Windows.Forms.ComboBox();
			this.cbDurum = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dgvUrunler = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label10 = new System.Windows.Forms.Label();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnGiris);
			this.groupBox1.Controls.Add(this.txtSifre);
			this.groupBox1.Controls.Add(this.txtKullaniciAdi);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(44, 30);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 129);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kullanıcı Bilgileri";
			// 
			// btnGiris
			// 
			this.btnGiris.Location = new System.Drawing.Point(92, 93);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(100, 30);
			this.btnGiris.TabIndex = 4;
			this.btnGiris.Text = "Giriş Yap";
			this.btnGiris.UseVisualStyleBackColor = true;
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// txtSifre
			// 
			this.txtSifre.Location = new System.Drawing.Point(92, 51);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(100, 22);
			this.txtSifre.TabIndex = 3;
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Location = new System.Drawing.Point(92, 28);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 22);
			this.txtKullaniciAdi.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Şifre";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kullanıcı Adı";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.richTextBox1);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.cbDurum);
			this.groupBox2.Controls.Add(this.cbKategoriler);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtFiyati);
			this.groupBox2.Controls.Add(this.txtUrunAdi);
			this.groupBox2.Controls.Add(this.txtMarkasi);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(288, 30);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(594, 129);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ürün Girişi";
			// 
			// txtFiyati
			// 
			this.txtFiyati.Location = new System.Drawing.Point(89, 73);
			this.txtFiyati.Name = "txtFiyati";
			this.txtFiyati.Size = new System.Drawing.Size(100, 22);
			this.txtFiyati.TabIndex = 6;
			// 
			// txtUrunAdi
			// 
			this.txtUrunAdi.Location = new System.Drawing.Point(89, 22);
			this.txtUrunAdi.Name = "txtUrunAdi";
			this.txtUrunAdi.Size = new System.Drawing.Size(100, 22);
			this.txtUrunAdi.TabIndex = 5;
			// 
			// txtMarkasi
			// 
			this.txtMarkasi.Location = new System.Drawing.Point(89, 48);
			this.txtMarkasi.Name = "txtMarkasi";
			this.txtMarkasi.Size = new System.Drawing.Size(100, 22);
			this.txtMarkasi.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 16);
			this.label5.TabIndex = 3;
			this.label5.Text = "Fiyatı";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "Ürün Adı";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "Markası";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(204, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 16);
			this.label6.TabIndex = 7;
			this.label6.Text = "Kategori";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(204, 54);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 16);
			this.label8.TabIndex = 9;
			this.label8.Text = "Durum";
			// 
			// cbKategoriler
			// 
			this.cbKategoriler.FormattingEnabled = true;
			this.cbKategoriler.Items.AddRange(new object[] {
            "Elektronik",
            "Bilgisayar",
            "Telefon",
            "Tablet"});
			this.cbKategoriler.Location = new System.Drawing.Point(276, 14);
			this.cbKategoriler.Name = "cbKategoriler";
			this.cbKategoriler.Size = new System.Drawing.Size(121, 24);
			this.cbKategoriler.TabIndex = 10;
			// 
			// cbDurum
			// 
			this.cbDurum.AutoSize = true;
			this.cbDurum.Location = new System.Drawing.Point(276, 54);
			this.cbDurum.Name = "cbDurum";
			this.cbDurum.Size = new System.Drawing.Size(54, 20);
			this.cbDurum.TabIndex = 11;
			this.cbDurum.Text = "Aktif";
			this.cbDurum.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(276, 80);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 30);
			this.button1.TabIndex = 12;
			this.button1.Text = "Kaydet";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(418, 17);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 16);
			this.label7.TabIndex = 13;
			this.label7.Text = "Ürün Özellikleri";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(421, 36);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(167, 74);
			this.richTextBox1.TabIndex = 14;
			this.richTextBox1.Text = "";
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            "Sözleşmeyi Kabul Ediyorum",
            "Özel mesajları Kabul Etmiyorum",
            "Kararsızım"});
			this.checkedListBox1.Location = new System.Drawing.Point(44, 199);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(219, 55);
			this.checkedListBox1.TabIndex = 2;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(44, 275);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 3;
			// 
			// dgvUrunler
			// 
			this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUrunler.Location = new System.Drawing.Point(288, 199);
			this.dgvUrunler.Name = "dgvUrunler";
			this.dgvUrunler.RowHeadersWidth = 51;
			this.dgvUrunler.RowTemplate.Height = 24;
			this.dgvUrunler.Size = new System.Drawing.Size(240, 150);
			this.dgvUrunler.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label9);
			this.panel1.Location = new System.Drawing.Point(552, 199);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 150);
			this.panel1.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(62, 39);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 16);
			this.label9.TabIndex = 14;
			this.label9.Text = "Panel İçeriği";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Items.AddRange(new object[] {
            "Elektronik",
            "Bilgisayar",
            "Telefon",
            "Televizyon"});
			this.listBox1.Location = new System.Drawing.Point(770, 199);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 148);
			this.listBox1.TabIndex = 6;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(41, 320);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(68, 16);
			this.linkLabel1.TabIndex = 7;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "linkLabel1";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(41, 346);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(53, 16);
			this.label10.TabIndex = 8;
			this.label10.Text = "Telefon";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(115, 340);
			this.maskedTextBox1.Mask = "(999) 000-0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
			this.maskedTextBox1.TabIndex = 9;
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(894, 564);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvUrunler);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form5";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form5";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.TextBox txtKullaniciAdi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGiris;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtFiyati;
		private System.Windows.Forms.TextBox txtUrunAdi;
		private System.Windows.Forms.TextBox txtMarkasi;
		private System.Windows.Forms.ComboBox cbKategoriler;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox cbDurum;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DataGridView dgvUrunler;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
	}
}