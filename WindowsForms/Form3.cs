using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TIMER NESNESİ (ZAMANLAYICI) KULLANIMI
namespace WindowsForms
{//program.cs de : ()içinde hangi form yazılı olursa başlangıçta onu çalıştırır
 //windows form projesi çalıştırıldığında hangi formun açılacağını buradan ayarlıyoruz.
 //timer: zamanlayıcı, belli süreyle işlemler yaptırdığımız zamanlayıcı
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			//1 label ve 1 timer nesnesi eklendi
			timer1.Enabled = true;//timer1 nesnesini sayfa yüklenirken aktif hale getiriyoruz
			timer1.Interval = 1000; //timer ın milisaniye cinsinden bu şekilde ayarlayabiliriz
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			//tick olayı var timer da
			//design da alta eklenen nesneye çift click ile event oluşturulur
			Random renk = new Random(); //renk isminde rastgele sayı üreten nesne oluşturuldu
			this.BackColor = Color.FromArgb(renk.Next(1, 100), renk.Next(1, 100), renk.Next(1, 100)); //Burada this sınıfı geçerli formu temsil ediyor. Formun arkaplan rengine rastgele 1 ve 100 arası RGB renk kodlarını oluşturacak sayılar üretilecek
		}
	}
}