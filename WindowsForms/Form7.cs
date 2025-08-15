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
	//datetimepicker: kullanıcının bir tarih ve saat seçmesine ve bu tarih ve saati belirtilen biçimde görüntülemesine izin vermek için kullanılır.
	//datetimepicker - ValueChanged eventi ile değer değiştiğinde yapılacak işlemi yazdırır.
	//label-textbox-button
	//progressBar: yükleniyor imleci (girilen değer kadar süre ile yükleme gösterdik)
	public partial class Form7 : Form
	{
		public Form7()
		{
			InitializeComponent();
		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{//messagebox kısayolu mb tab
			MessageBox.Show("İki tarih arasında " + (dateTimePicker2.Value - dateTimePicker1.Value).Days.ToString() + " gün vardır.");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(textBox1.Text))
			{//textbox boş değilse içindeki sayı kadar döndür.
			 //i sayi değişkeni oluşturup içindeki değeri i ye eşitledik
				int sayi = Convert.ToInt32(textBox1.Text);
				progressBar1.Maximum = sayi;

				for (int i = 0; i < sayi; i++)
				{
					progressBar1.Value = i;
				}
			}
			else
			{
				MessageBox.Show("Lütfen Bir Sayı Giriniz!");
			}
		}
	}
}