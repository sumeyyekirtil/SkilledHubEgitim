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
	public partial class Kategoriler : Form
	{
		public Kategoriler()
		{
			InitializeComponent();
		}
		UrunDbModel context = new UrunDbModel();
		private void Kategoriler_Load(object sender, EventArgs e)
		{
			dgvKategoriler.DataSource = context.Categories.ToList();
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
					dgvKategoriler.DataSource = context.Categories.ToList();

					//ekledikten sonra textbox ları boşalt
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

		}
	}
}