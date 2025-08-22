﻿using System;
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
	public partial class Kategoriler : Form
	{
		public Kategoriler()
		{
			InitializeComponent();
		}
		UrunDbModel context = new UrunDbModel();
		private void Kategoriler_Load(object sender, EventArgs e)
		{
			Yukle();
		}
		void Yukle()
		{ //uzun uzun yazmak yerine Yukle metodunu çağırmak yeterli olur
			dgvKategoriler.DataSource = context.Categories.ToList();
			//her işlem sonrası yazmaya gerek kalmıyor!!!
			//btnEkle.Enabled = true;
			//btnGuncelle.Enabled = false;
			//btnSil.Enabled = false;

			//işlemden sonra textbox sil
			txtKategoriAdi.Text = string.Empty;
			txtKategoriAciklamasi.Text = "";
			cbDurum.Checked = false;

		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			try
			{
				var Category = new Category()
				{
					Name = txtKategoriAdi.Text,
					Description = txtKategoriAciklamasi.Text,
					CreateDate = DateTime.Now,
					Durum = cbDurum.Checked
				};
				context.Categories.Add(Category); //boş kategori ekledik

				int sonuc = context.SaveChanges(); //context deki değişiklikleri kayıt ettik
				if (sonuc > 0)
				{
					//dgvKategoriler.DataSource = context.Categories.ToList(); //yerine ->
					Yukle();

					//ekledikten sonra textbox ları boşalt -> Yukle() içinde
					txtKategoriAdi.Clear();
					txtKategoriAciklamasi.Clear();
					cbDurum.Checked = false;

					MessageBox.Show("Kayıt Başarılı!");
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Hata Oluştu!");
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			int id = (int)dgvKategoriler.CurrentRow.Cells[0].Value; //seçili satırdaki kaydın id sini yakaladık
			var kayit = context.Categories.Find(id); //vt bulunan kayıt ile kaydı değiştir

			kayit.Name = txtKategoriAdi.Text;
			kayit.Description = txtKategoriAciklamasi.Text;
			kayit.Durum = cbDurum.Checked;

			int sonuc = context.SaveChanges(); //context deki değişiklikleri kayıt ettik
			if (sonuc > 0)
			{
				//dgvKategoriler.DataSource = context.Categories.ToList();
				Yukle();

				//güncelledikten sonra textbox boşalt
				txtKategoriAdi.Clear();
				txtKategoriAciklamasi.Clear();
				cbDurum.Checked = false;

				MessageBox.Show("Güncelleme Başarılı!");
			}
			else
			{
				MessageBox.Show("Güncelleme Başarısız! Lütfen Tüm Alanları Doldurunuz!");
			}
		}

		private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e) //kayıt tıklandığı zaman gelsin
		{
			//güvenli yöntemi : db id yi çekip vt eşleşen kayıtı bulup göstermek = böylece veritabanından veriler gelir
			int id = (int)dgvKategoriler.CurrentRow.Cells[0].Value; //seçili satırdaki kaydın id sini yakaladık
			var kayit = context.Categories.Find(id); //id yi ef nin find metoduna verip eşleşen kategoriyi getirdik.

			#region  Db den gelen kaydı ekrana doldur
			txtKategoriAdi.Text = kayit.Name;
			txtKategoriAciklamasi.Text = kayit.Description;
			cbDurum.Checked = kayit.Durum;
			#endregion
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			int id = (int)dgvKategoriler.CurrentRow.Cells[0].Value; //seçili satırdaki kaydın id sini yakaladık
			var kayit = context.Categories.Find(id); //vt bulunan kayıt ile

			context.Categories.Remove(kayit); //kaydı sil

			int sonuc = context.SaveChanges(); //context deki değişiklikleri kayıt ettik
			if (sonuc > 0)
			{
				Yukle();

				//silme işleminden sonra txt boşalt ->
				txtKategoriAdi.Clear();
				txtKategoriAciklamasi.Clear();
				cbDurum.Checked = false;

				MessageBox.Show("Kayıt Silme Başarılı!");
			}
			else
			{
				MessageBox.Show("Kayıt Silme Başarısız! Lütfen Tüm Alanları Doldurunuz!");
			}
		}
	}
}