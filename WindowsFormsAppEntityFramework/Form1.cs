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
//ENTITY FRAMEWORK : import : project - sağ tık - manage NuGet packages : entity framework install - I accept
//2. yöntemi : Solution Explorer - sağ tık - manage NuGet packages for solition - install edeceğimiz projeyi seçme işlemi yaptırır (birden fazla proje seçilebilir)
//DB - VT işlemleri : project - sağ tık - add class -  UrunDbModel
//UrunDbModel : kütüphane import - using System.Data.Entity;
//Referans almak : project - referance - add referance - istenilen projeyi ekleme yapılır
//app.config : ayarların tutulduğu yer - proje bilgileri bulunur
//app.config connection string ekleme : connectionString tagleri aç/kapat add ekleyip name özelliği ile base kısmındaki ismi import edilir. connectionString bağlantı adresi string olarak yazılır. İçine provider adı ekleme using sqlclient adresini yazmak

namespace WindowsFormsAppEntityFramework
{
	//ENTITY FRAMEWORK : Ado Net işlemlerini daha kolay ve hızlı yapabilen kütüphanedir
	//Sql işlemlerini çok kolaylaştırır.
	//Crud işlemleri ve büyük uygulama arkaplan kodlama işleminde Ado Net + Stored Procedure kullanılır.
	//Genelde Entity Framework kullanılır küçük uygulamalarda (hızlı işlemlerde)
	//Ado Net gibi hazır gelmiyor sonradan kütüphane olarak yükleniyor
	//savechanges : unit of work pattern -> veritabanı işlemlerinin yönetimini kolaylaştıran ve işlemleri birbirleriyle bağlantılı bir şekilde gruplandırmayı sağlayan yazılım tasarım deseni.
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		UrunDbModel context = new UrunDbModel(); //dal gibi oluşturduk nesneyi
		private void Form1_Load(object sender, EventArgs e)
		{
			dgvUrunListesi.DataSource = context.Products.ToList(); //entity framework ile vt daki ürünleri çekme
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{//bu kısmı try - catch bloğuna aldık
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

				context.Products.Add(urun); //context nesnesindeki products tablosuna ürün ekle
				int sonuc = context.SaveChanges(); //context deki değişiklikleri db yansıt 
				//savechanges : eğer sonuç 0 dan büyük değilse yapılan değişiklikleri geri al vt işlemi sil görevi görür
				if (sonuc > 0)
				{
					dgvUrunListesi.DataSource = context.Products.ToList(); //ekrandaki dgv tekrar yüklüyoruz yoksa ekranda gözükmez!

					txtUrunAdi.Clear();
					txtUrunFiyati.Clear();
					txtStokMiktari.Clear();
					txtAra.Clear();
					cbDurum.Checked = false;

					MessageBox.Show("Kayıt Başarılı!");
				}
				else
				{
					MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
				}
			}
			catch (Exception) //hata kısmı error olursa detaylı çzüm için ekranda gösterilir (güvenlik açığı).
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
			btnGuncelle.Enabled = true;
			btnSil.Enabled = true;
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Kaydı silmek istiyor musunuz!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					var product = context.Products.Find((int)dgvUrunListesi.CurrentRow.Cells[0].Value); //kayıtı bul
					context.Products.Remove(product); //kayıtı sil

					int sonuc = context.SaveChanges(); //id ulaşılan yere getirdik
					if (sonuc > 0)
					{
						dgvUrunListesi.DataSource = context.Products.ToList();
						btnEkle.Enabled = true;
						btnGuncelle.Enabled = false;
						btnSil.Enabled = false;

						txtUrunAdi.Clear();
						txtUrunFiyati.Clear();
						txtStokMiktari.Clear();
						txtAra.Clear();
						cbDurum.Checked = false;

						MessageBox.Show("Kayıt Silindi!");
					}
				}
				catch (Exception)
				{
					MessageBox.Show("Hata Oluştu!");
				}
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{//güncellemede ve sil de id i unutulmamalı
			try
			{
				var urun = new Product
				{
					Id = (int)dgvUrunListesi.CurrentRow.Cells[0].Value, //güncellemede id unutma!
					UrunAdi = txtUrunAdi.Text,
					UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text),
					StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
					Durum = cbDurum.Checked
				};

				var product = context.Entry(urun); //güncelleme için ürün nesnesine abone olmak, product tablosuna eklenecek ürünü yakala ve product nesnesine ata
				product.State = System.Data.Entity.EntityState.Modified; //product nesnesinin durumunu Modified-değiştirildi olarak işaretle
				int sonuc = context.SaveChanges(); //context deki değişiklikleri vt yansıt
				if (sonuc > 0)
				{
					dgvUrunListesi.DataSource = context.Products.ToList(); //ekrandaki dgv tekrar yüklüyoruz yoksa ekranda gözükmez!

					txtUrunAdi.Clear();
					txtUrunFiyati.Clear();
					txtStokMiktari.Clear();
					txtAra.Clear();
					cbDurum.Checked = false;

					MessageBox.Show("Kayıt Başarılı!");
				}
				else
				{
					MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show("Hata Oluştu! Lütfen Tüm Alanları Doldurunuz!" + hata);
			}
		}
	}
}