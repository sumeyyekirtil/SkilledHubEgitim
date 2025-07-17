using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppAdoNet;

namespace WindowsFormsAppEntityFramework
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		UrunDbModel context = new UrunDbModel();
		private void Form1_Load(object sender, EventArgs e)
		{
			dgvUrunListesi.DataSource = context.Products.ToList(); //ef ile vt daki ürünleri çekme
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			try
			{
				//ürün nesnesini de bu alana alınması gerekli
				var urun = new Product
				{
					UrunAdi = txtUrunAdi.Text,
					UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text),
					StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
					Durum = cbDurum.Checked
				};
				//bu kısmı try a aldık
				context.Products.Add(urun); //context nesnesindeki products tablosuna ürün ekle
				int sonuc = context.SaveChanges(); //context deki değişiklikleri vt yansıt
				if (sonuc > 0)
				{
					dgvUrunListesi.DataSource = context.Products.ToList(); //ekrandaki dgv tekrar yüklüyoruz yoksa ekranda gözükmez!
					MessageBox.Show("Kayıt Başarılı!");
				}
				else
				{
					MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show("Hata Oluştu! Lütfen Tüm Alanları Doldurunuz!");
			}
		}

		private void dgvUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//0. index ıd olduğu için 1 den başlatıldı
			txtUrunAdi.Text = dgvUrunListesi.CurrentRow.Cells[1].Value.ToString();
			txtUrunFiyati.Text = dgvUrunListesi.CurrentRow.Cells[2].Value.ToString();
			txtStokMiktari.Text = dgvUrunListesi.CurrentRow.Cells[3].Value.ToString();
			cbDurum.Checked = (bool)dgvUrunListesi.CurrentRow.Cells[4].Value;

			btnEkle.Enabled = false;
			btnGüncelle.Enabled = true;
			btnSil.Enabled = true;
		}

		private void btnGüncelle_Click(object sender, EventArgs e)
		{ //güncellemede ve sil de id i unutulmamalı
			try
			{
				//ürün nesnesini de bu alana alınması gerekli
				var urun = new Product
				{
					Id = (int)dgvUrunListesi.CurrentRow.Cells[0].Value,
					UrunAdi = txtUrunAdi.Text,
					UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text),
					StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
					Durum = cbDurum.Checked
				};
				//bu kısmı try a aldık
				var product = context.Entry(urun); //güncelleme için ürün nesnesine abone olmak ,product tablosuna eklenecek ürünü yakala ve product nesnesine ata
				product.State = System.Data.Entity.EntityState.Modified; //product nesnesinin durumunu Modified-değiştirildi olarak işaretle
				int sonuc = context.SaveChanges(); //context deki değişiklikleri vt yansıt
				if (sonuc > 0)
				{
					dgvUrunListesi.DataSource = context.Products.ToList(); //ekrandaki dgv tekrar yüklüyoruz yoksa ekranda gözükmez!
					MessageBox.Show("Kayıt Başarılı!");
				}
				else
				{
					MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show("Hata Oluştu! Lütfen Tüm Alanları Doldurunuz!");
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Kaydı silmek istiyor musunuz!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					var product = context.Products.Find((int)dgvUrunListesi.CurrentRow.Cells[0].Value);
					context.Products.Remove(product);

					int sonuc = context.SaveChanges(); //id ulaşılan yere getirdik
					if (sonuc > 0)
					{
						dgvUrunListesi.DataSource = context.Products.ToList();
						btnEkle.Enabled = true;
						btnGüncelle.Enabled = false;
						btnSil.Enabled = false;
						MessageBox.Show("Kayıt Silindi!");
					}
				}
				catch (Exception)
				{
					MessageBox.Show("Hata Oluştu!");
				}
			}
		}
	}
}