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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		ProductDal productDal = new ProductDal(); //ProductDal nesnesi oluşturduk
		private void Form1_Load(object sender, EventArgs e)
		{
			//dgvUrunListesi.DataSource = productDal.GetAll(); //productDal nesnesi içerisinde yazdığımız GetAll() metodundan gelen ürün listesini çek ve ekrandaki dgvUrunListesi ne veri kaynağı olarak yolla.
			
			//ikinci yöntem dgv yazdırma
			dgvUrunListesi.DataSource = productDal.GetDataTable(); //dt ile getir
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			//hata alınca çökmemesi için
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
				int sonuc = productDal.Add(urun);
				if (sonuc > 0)
				{
					dgvUrunListesi.DataSource = productDal.GetAll(); //ekrandaki dgv tekrar yüklüyoruz yoksa ekranda gözükmez!
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

		//dgv properties de şimşek ile click eventine gidip cellclick eventi oluşturuldu
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
		{
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
				int sonuc = productDal.Update(urun);
				if (sonuc > 0)
				{
					dgvUrunListesi.DataSource = productDal.GetAll(); //ekrandaki dgv tekrar yüklüyoruz yoksa ekranda gözükmez!
					btnEkle.Enabled = true;
					btnGüncelle.Enabled = false;
					btnSil.Enabled = false;
					MessageBox.Show("Kayıt Başarılı!");
				}
				else
				{
					MessageBox.Show("Güncelleme Başarısız! Lütfen Tüm Alanları Doldurunuz!");
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show("Güncelleme Başarısız! Lütfen Tüm Alanları Doldurunuz!");
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Kaydı silmek istiyor musunuz!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					int sonuc = productDal.Delete((int)dgvUrunListesi.CurrentRow.Cells[0].Value); //id ulaşılan yere getirdik
					if (sonuc > 0)
					{
						dgvUrunListesi.DataSource = productDal.GetAll();
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