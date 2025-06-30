using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			////timer1.Start Enabled = true; //timer1 nesnesi sayfa yüklenirken aktif hale getiriyoruz.
			//timer1.Interval = 400; //timer ın süresi milisaniye cinsinden bu şekilde ayarlayabiliriz.
			//Random renk = new Random();//renk isminde rastgele sayı üretene nesne oluşturduk
			//this.BackColor = Color.FormArgb(renk.Next()1, 100), renk.Next(1, 100);// Burada this sınıfı geçerli formu  i temsil ediyor. Form3 in arkaplan rengine rastgele 1 ile 100 arası RGB renk kodlarını oluşturacak sayılar üretecek
		}
	}
}