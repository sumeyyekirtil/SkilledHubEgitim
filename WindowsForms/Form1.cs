using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms //kullanıcını göredüğü ekranı tasarlıyoruz
{
// form1 açıkken gelir : toolbox
	public partial class Form1 : Form
	{ //proje .alışmaya devam ettiği sürece herhangi bir değişiklik yapılamaz
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load_1(object sender, EventArgs e) //desing de olan yapılara çift tık yapılırsa .cs de olayı oluşur
		{
			//ekrandaki form yüklendiğinde bu metot çalışır, bveri tabanından veri çekip ekrana gönderme gibi işlemleri burada yapabiliriz.
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			//form2.Show(); //çağırılan form show metoduyla gösterilirse, tüm formlara erişim sağlanabilir.
			form2.ShowDialog();//çağırılan form ShowDialog metoduyla gösterilirse , üstteki form kapatılana kadar alttaki forma erişim engellenir.
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
			form2.AdSoyad = txtAdSoyad.Text;//textbox dan aldığım değeri property ile aktarım veri gönderimi sağlsamış olduk
			form2.ShowDialog();
		}
	}
}