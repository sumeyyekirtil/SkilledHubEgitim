using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//KULLANICIYA MESAJ VERDİRME!
namespace WindowsForms
{//form-sağ click-property start position: centerscreen ayarlandı
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(textBox1.Text)) //eğer textBox1 boş değilse
			{
				MessageBox.Show("Merhaba " + textBox1.Text);// MessageBox sınıfındaki Show metodu, ekranda uyarı penceresi çıkartmamızı sağlar
			}
			else
			{//Show metodunun text, caption, buttons, icon parameters kullanıldı.
				MessageBox.Show("Lütfen Adınızı Giriniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				//MessageBoxButtons.OKCancel(farklı seçenekleri var)
			}
		}
	}
}