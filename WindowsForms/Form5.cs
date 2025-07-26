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

//
namespace WindowsForms
{//groupbox: ekrandaki componentleri gruplamak için kullanılır. Property text-name bilgisi değiştirilir.
//label larda yazan detaya göre kullanıcı bilgi girer.
//textbox dan veriyi alırız.
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
				MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez!", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Question);
			}
			else if(string.IsNullOrEmpty(txtSifre.Text)) //sifre text boş ise
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
			MessageBox.Show(cbKategoriler.SelectedItem + "Kategorisine " + txtUrunAdi.Text + "Ürünü Eklendi!");
		}
	}
}