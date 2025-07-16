namespace WindowsFormsAppAdoNet
{
	partial class Kategoriler
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
			this.dgvKategoriler = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtKategoriAdi = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.txtKategoriAciklamasi = new System.Windows.Forms.RichTextBox();
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvKategoriler
			// 
			this.dgvKategoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKategoriler.Location = new System.Drawing.Point(12, 12);
			this.dgvKategoriler.Name = "dgvKategoriler";
			this.dgvKategoriler.RowHeadersWidth = 51;
			this.dgvKategoriler.RowTemplate.Height = 24;
			this.dgvKategoriler.Size = new System.Drawing.Size(489, 426);
			this.dgvKategoriler.TabIndex = 0;
			this.dgvKategoriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategoriler_CellContentClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSil);
			this.groupBox1.Controls.Add(this.btnGuncelle);
			this.groupBox1.Controls.Add(this.btnEkle);
			this.groupBox1.Controls.Add(this.txtKategoriAciklamasi);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtKategoriAdi);
			this.groupBox1.Location = new System.Drawing.Point(518, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(270, 426);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kategori Bilgileri";
			// 
			// txtKategoriAdi
			// 
			this.txtKategoriAdi.Location = new System.Drawing.Point(164, 19);
			this.txtKategoriAdi.Name = "txtKategoriAdi";
			this.txtKategoriAdi.Size = new System.Drawing.Size(100, 22);
			this.txtKategoriAdi.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Kategori Adı";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Açıklama";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Durum";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(164, 62);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(95, 20);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// txtKategoriAciklamasi
			// 
			this.txtKategoriAciklamasi.Location = new System.Drawing.Point(28, 136);
			this.txtKategoriAciklamasi.Name = "txtKategoriAciklamasi";
			this.txtKategoriAciklamasi.Size = new System.Drawing.Size(231, 165);
			this.txtKategoriAciklamasi.TabIndex = 7;
			this.txtKategoriAciklamasi.Text = "";
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(28, 324);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(75, 23);
			this.btnEkle.TabIndex = 8;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(28, 353);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
			this.btnGuncelle.TabIndex = 9;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(28, 382);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(75, 23);
			this.btnSil.TabIndex = 10;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			// 
			// Kategoriler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvKategoriler);
			this.Name = "Kategoriler";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kategoriler";
			this.Load += new System.EventHandler(this.Kategoriler_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvKategoriler;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtKategoriAdi;
		private System.Windows.Forms.RichTextBox txtKategoriAciklamasi;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnEkle;
	}
}