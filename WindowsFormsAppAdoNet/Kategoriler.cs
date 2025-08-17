using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAdoNet
{
	public partial class Kategoriler : Form
	{
		public Kategoriler()
		{
			InitializeComponent();
		}

		CategoryDal categoryDal = new CategoryDal();
		private void Kategoriler_Load(object sender, EventArgs e)
		{
			dgvKategoriler.DataSource = categoryDal.GetDataTable("select * from Kategoriler");
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			try
			{
				var kategori = new Category()
				{
					Name = txtKategoriAdi.Text,
					Description = txtKategoriAciklamasi.Text,
					CreateDate = DateTime.Now,
					Durum = cbDurum.Checked
				};
				var sonuc = categoryDal.Add(kategori);
				if (sonuc > 0)
				{
					dgvKategoriler.DataSource = categoryDal.GetDataTable("Select * from Kategoriler");

					//ekledikten sonra textbox ları boşalt
					txtKategoriAdi.Clear();
					txtKategoriAciklamasi.Clear();
					cbDurum.Checked = false;

					MessageBox.Show("Kayıt Başarılı!");
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show("Hata Oluştu!" + hata);
			}
		}

		private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtKategoriAdi.Text = dgvKategoriler.CurrentRow.Cells[1].Value.ToString();
			txtKategoriAciklamasi.Text = dgvKategoriler.CurrentRow.Cells[2].Value.ToString();
			cbDurum.Checked = Convert.ToBoolean(dgvKategoriler.CurrentRow.Cells[3].Value);

			btnEkle.Enabled = false;
			btnGuncelle.Enabled = true;
			btnSil.Enabled = true;
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			try
			{
				var kategori = new Category()
				{
					Id = (int)dgvKategoriler.CurrentRow.Cells[0].Value,
					Name = txtKategoriAdi.Text,
					Description = txtKategoriAciklamasi.Text,
					CreateDate = (DateTime)dgvKategoriler.CurrentRow.Cells[4].Value,
					Durum = cbDurum.Checked
				};
				var sonuc = categoryDal.Update(kategori);
				if (sonuc > 0)
				{
					dgvKategoriler.DataSource = categoryDal.GetDataTable("select * from Kategoriler");

					//güncelledikten sonra textbox ları boşalt
					txtKategoriAdi.Clear();
					txtKategoriAciklamasi.Clear();
					cbDurum.Checked = false;

					btnEkle.Enabled = true;
					btnGuncelle.Enabled = false;
					btnSil.Enabled = false;

					MessageBox.Show("Kayıt Başarılı!");
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show("Hata Oluştu!" + hata);
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Kaydı silmek istiyor musunuz!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					int sonuc = categoryDal.Delete((int)dgvKategoriler.CurrentRow.Cells[0].Value); //id ulaşılan yere getirdik
					if (sonuc > 0)
					{
						dgvKategoriler.DataSource = categoryDal.GetDataTable("Select * from Kategoriler");

						btnEkle.Enabled = true;
						btnGuncelle.Enabled = false;
						btnSil.Enabled = false;

						//sildikten sonra textbox ları boşalt
						txtKategoriAdi.Clear();
						txtKategoriAciklamasi.Clear();
						cbDurum.Checked = false;

						MessageBox.Show("Kayıt Silindi!");
					}
				}
				catch (Exception hata)
				{
					MessageBox.Show("Hata Oluştu!" + hata);
				}
			}
		}
	}
}