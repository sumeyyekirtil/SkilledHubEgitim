using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Property-name bilgilerinde türkçe karakter kullanılmaz!
//CTRL ile tool copy-paste yapılabilir. (Değiştirilen propertyler de aynen geçer!)
//!!!Oluşturulmaması gerek bir click özelliği oluşturulursa ctrl+z, olmuyorsa kod kısmından silip design lısmındaki go to line ile gösterilen click satırı silinirse işlem geri alınmış olur!

namespace WindowsForms
{//groupbox: ekrandaki componentleri gruplamak için kullanılır. Property text-name bilgisi değiştirilir.
 //label larda yazan detaya göre kullanıcı bilgi girer.
 //textbox dan veriyi alırız.
 //combobox: aşağı açılır menü (property-name genellikle cb ile yazılır)
 //checkbox -dropdownlist (web-select diye geçer): T/F işaretleme ile kontrol sağlar.
 //checkbox-küçük ok (smart tag): edit items ile satır değerleri(collections) girilebilir.
 //richtextbox: zengin metin yazıcı, textboxdan daha geniş ve çok karakter gösterir.
 //checkedlistbox: çoklu işaretleme seçeneği (sözleşme kabulleri gibi)
 //checkedlistbox - smart tag:edit items ile seçenek girilebilir.
 //datetimepicker: tarih seçici component
 //datagridview: veri gösterimi için kullanılan alan (vt dan veri gösterimi için de kullanılır).
 //datagridview kolonu boyutunu doldurması için : property-columnautosizemode -> fill seçeneği ile yapılır. 
 //panel: içine label ekleyip yazı gösterebiliriz.
 //listbox: combobox ın açık hali. edit items ile satır seçeneklerini doldurabiliriz.
 //linklabel: buton yerine metin şeklinde link oluşturmaya yarar.
 //maskedtextbox: smart tag - set mask seçeneğinden format biçimini seçebiliriz. (maske ayarlandı)
 //radiobutton: işaretleme butonu !işaretlemeden sonra geri alınamaz-ekranı komple kapatılması lazım! (cookie lerde kullanılabilir.)
 //tabcontrol: tab sistemi aktif ediyor (tab1-property : collections dan başlık değiştirebiliriz.)
 //tablcontrol içine label vs eklenebilir.
 //treeview: add root ile ana başlık add child ile başlık altına alt menü ekleyip ağaç formasyonu gösterim sağlar
 //treeview-smart tag: edit nodes ile add root ile menü eklenebilir.
 //picturebox:resim gösterme kutusu
 //picturebox- smart tag: choose ımage ile proje/local source den herhangi bir resim seçip import ile gösterim sağlar
 //size mode : zoom özelliği (veya farklı özellikleri) kullanılarak resim bozulmadan sergilenmiş olur.
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
		}

		private void btnGiris_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtKullaniciAdi.Text)) //kullanıcı adı için text boş ise
			{
				MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
			}
			else if (string.IsNullOrEmpty(txtSifre.Text)) //sifre text boş ise
			{
				MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
			}
			else
			{
				string veritabanindakiKullanici = "Admin", veritabanindakiSifre = "Admin123";
				if (txtKullaniciAdi.Text == veritabanindakiKullanici && txtSifre.Text == veritabanindakiSifre) //verilen kayıt doğru ise (& ve bağlacı ile 1-1=1)
				{
					this.Hide();//bu formu gizle 
					Form4 form4 = new Form4();
					form4.ShowDialog(); //önceki formu aç
				}
				else
				{
					MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);//giriş başarısızsa uyarı penceresi göster
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//datagridview e kayıt ekleme
			dgvUrunler.ColumnCount = 3; //kaç kolon veri ekleyeceğimizi ayarladık.
			
			//veri listesinim üst satırındaki başlıkları ayarlıyoruz.
			dgvUrunler.Columns[0].Name = "Kategorisi";
			dgvUrunler.Columns[1].Name = "Ürün Adı";
			dgvUrunler.Columns[2].Name = "Fiyatı";

			//Satıra yeni ürün bilgisi ekleme
			dgvUrunler.Rows.Add(cbKategoriler.SelectedItem.ToString(), txtUrunAdi.Text, txtFiyati.Text);
			
			//buton ile kayıt gerçekleştiğine dair geri dönüt alınması için
			MessageBox.Show(cbKategoriler.SelectedItem + " Kategorisine " + txtUrunAdi.Text + " Ürünü Eklendi!");
		}
	}
}