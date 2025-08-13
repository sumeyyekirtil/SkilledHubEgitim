using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//camelCase e göre isimlendirme yapıyoruz.
//solution - project - sağ tık - set a startup project : buradan çalıştır
//desing için buton kodlarını göndermek için önce productdal da metot tanımlaması yapıyoruz(sql sorgusu ile) sonra buton içine kod tanımlıyoruz.

//Veritabanı işlemleri nasıl çalıştığı konu alındı
//form :start position : center screen
//textbox : txtAra
//button : btnAra
//datagridview : dgvUrunListesi - property - autosizecolumn(fill) 
//groupbox :
//4 label
//textbox : txtUrunAdi
//textbox : txtUrunFiyati
//textbox : txtStokMiktari
//checkbox : cbDurum
//button : btnEkle
//form name : Ürün Yönetimi

//groupbox dan alınan verileri kullanabilmek için bir class a ihtiyacımız var : add-class : product

/*sql management - database -add new db - add new table - product (ürün) table - columnları oluşturuyoruz 
product - edit top 200 rows - ürünleri ekle
*/
//Veri işlemleri için add - class : OrtakDAL --using System.Data; //veri işlemleri için gerekli kütüphane --using System.Data.SqlClient; //ADO.NET kütüphaneleri ekle
//ürün takibi için (ortak metotları ortak class a al) add - class : Productdal using System; using System.Collections.Generic; using System.Data; //vt işlemleri için using System.Data.SqlClient; //ADO.NET kütüphaneleri (ortak metotları ortak class a al)
namespace WindowsFormsAppAdoNet
{
	//toolbox ları çoğaltmak için ctrl ile çekip bırakabiliriz.
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		ProductDal productDal = new ProductDal(); //ProductDal nesnesi oluşturduk
		private void Form1_Load(object sender, EventArgs e)
		{ //sql e bağlanıp işlem yaptırma : form load
			//dgvUrunListesi.DataSource = productDal.GetAll(); //productDal nesnesi içerisinde yazdığımız GetAll() metodundan gelen ürün listesini çek ve ekrandaki dgvUrunListesi ne veri kaynağı olarak yolla.
			
			//ikinci yöntem dgv yazdırma
			dgvUrunListesi.DataSource = productDal.GetDataTable("select * from Urunler"); //dt ile getir
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			//hata alınca çökmemesi için try-catch
			try
			{
				//ürün nesnesinin de bu alana alınması gerekli
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
				else //kayıt başarısızsa
				{
					MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show("Hata Oluştu! Lütfen Tüm Alanları Doldurunuz!");
			}
		}

		//dgv properties de şimşek ile click eventine gidip çift tık cellclick eventi oluşturuldu (hücre : cell)
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
				//btnEkle deki aynı try-catch
				var urun = new Product
				{
					Id = (int)dgvUrunListesi.CurrentRow.Cells[0].Value,
					UrunAdi = txtUrunAdi.Text,
					UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text),
					StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
					Durum = cbDurum.Checked
				};
				//bu kısmı try a aldık
				int sonuc = productDal.Update(urun); //update komutu değişiyor.
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
			if (MessageBox.Show("Kaydı silmek istiyor musunuz!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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