using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
	public partial class Form2 : Form //miras alındı
	{
		public Form2() //constructor
		{
			InitializeComponent();
		}
		public string AdSoyad { get; set; } //değer tanımlaması önce burada yapılıyor
		private void Form2_Load(object sender, EventArgs e)
		{
			lblMesaj.Text = "Hoşgeldin " + AdSoyad;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			form1.ShowDialog(); //dialog: işlemin tamamlanmasını bekler
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close(); //kapat
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Application.Exit(); //uygulamayı kapat
		}
	}
}