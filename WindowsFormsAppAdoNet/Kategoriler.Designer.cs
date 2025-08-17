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
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnEkle = new System.Windows.Forms.Button();
			this.txtKategoriAciklamasi = new System.Windows.Forms.RichTextBox();
			this.cbDurum = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtKategoriAdi = new System.Windows.Forms.TextBox();
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
			this.dgvKategoriler.Size = new System.Drawing.Size(484, 426);
			this.dgvKategoriler.TabIndex = 0;
			this.dgvKategoriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategoriler_CellClick);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
			this.groupBox1.Controls.Add(this.btnSil);
			this.groupBox1.Controls.Add(this.btnGuncelle);
			this.groupBox1.Controls.Add(this.btnEkle);
			this.groupBox1.Controls.Add(this.txtKategoriAciklamasi);
			this.groupBox1.Controls.Add(this.cbDurum);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtKategoriAdi);
			this.groupBox1.Location = new System.Drawing.Point(518, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(304, 426);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kategori Bilgileri";
			// 
			// btnSil
			// 
			this.btnSil.BackColor = System.Drawing.Color.Tomato;
			this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSil.ForeColor = System.Drawing.SystemColors.MenuBar;
			this.btnSil.Location = new System.Drawing.Point(203, 363);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(75, 45);
			this.btnSil.TabIndex = 10;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = false;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.BackColor = System.Drawing.Color.Yellow;
			this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.Location = new System.Drawing.Point(109, 364);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(88, 45);
			this.btnGuncelle.TabIndex = 9;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = false;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnEkle
			// 
			this.btnEkle.BackColor = System.Drawing.Color.Lime;
			this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnEkle.ForeColor = System.Drawing.SystemColors.Desktop;
			this.btnEkle.Location = new System.Drawing.Point(28, 363);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(75, 45);
			this.btnEkle.TabIndex = 8;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = false;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// txtKategoriAciklamasi
			// 
			this.txtKategoriAciklamasi.Location = new System.Drawing.Point(28, 136);
			this.txtKategoriAciklamasi.Name = "txtKategoriAciklamasi";
			this.txtKategoriAciklamasi.Size = new System.Drawing.Size(250, 209);
			this.txtKategoriAciklamasi.TabIndex = 7;
			this.txtKategoriAciklamasi.Text = "";
			// 
			// cbDurum
			// 
			this.cbDurum.AutoSize = true;
			this.cbDurum.Location = new System.Drawing.Point(178, 61);
			this.cbDurum.Name = "cbDurum";
			this.cbDurum.Size = new System.Drawing.Size(68, 20);
			this.cbDurum.TabIndex = 6;
			this.cbDurum.Text = "Durum";
			this.cbDurum.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Durum";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Açıklama";
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
			// txtKategoriAdi
			// 
			this.txtKategoriAdi.Location = new System.Drawing.Point(178, 19);
			this.txtKategoriAdi.Name = "txtKategoriAdi";
			this.txtKategoriAdi.Size = new System.Drawing.Size(100, 22);
			this.txtKategoriAdi.TabIndex = 0;
			// 
			// Kategoriler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(834, 450);
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
		private System.Windows.Forms.CheckBox cbDurum;
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