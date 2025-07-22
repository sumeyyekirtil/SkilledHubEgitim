using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//form çalışmazsa arka planda çalışıyor hatası çözümü görev yöneticisinden kapatılmasıdır.

namespace WindowsForms
//WindowsForms windows a özel masaüstü uygulaması
//kullanıcının gördüğü ekranı tasarlıyoruz
//form.design üzerinde sağ click-property ile özelliklerini görürüz
//yeni form için: project-sağ click-add-forms
//design üzeeinden çift click ile eventi oluşturulup backend tarafına geçer.
//reset -> window-reset window layout: ile tasarım sıfırlanır
//toolbox -> view-toolbox: desing sayfasının propları (sadece design sayfası açıkken görünür olur!)
//label: başlık yazdırır (text özelliği ile)
//button: buton açar
//textbox: içine değer yazdırır klavyeden, property-name isim verilir her isim benzersiz olmalı
//datagridview:
//groupbox:
{
	public partial class Form1 : Form
	{ //proje .alışmaya devam ettiği sürece herhangi bir değişiklik yapılamaz
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e) //desing de olan yapılara çift tık yapılırsa .cs de olayı oluşur
		{
			//ekrandaki form yüklendiğinde bu metot çalışır, veritabanından veri çekip ekrana gönderme gibi işlemleri burada yapabiliriz.
		}

		private void button1_Click(object sender, EventArgs e)
		{//buton1 işlemleri
			Form2 form2 = new Form2();
			//form2.Show(); //çağırılan form Show metoduyla gösterilirse, tüm formlara erişim sağlanabilir.
			                //show: art arda açılım yapar
			form2.ShowDialog();//çağırılan form ShowDialog metoduyla gösterilirse, üstteki form kapatılana kadar alttaki forma erişim engellenir.
			//this.Hide();//form 2 yi açtıktan sonra , bu formu (form 1) gizle
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//this.Close(); //formu kapat
			Application.Exit(); //uygulamayı kapat
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.AdSoyad = txtAdSoyad.Text;//textbox dan aldığımız değeri property ile aktarım ile veri gösterim sağlamış olduk
			form2.ShowDialog();
		}
	}
}