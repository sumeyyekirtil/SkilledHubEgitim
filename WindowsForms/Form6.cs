using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
//NumericUpDown: sayısal girdi ayarlayıp döndürme işlemine yarar.
//NumericUpDown - valuechanged olayı tetiklenir.
//NumericUpDown - propery - value ile değer ataması yapılır. (minumum gibi değerlerde ayarlanabilir)
//DomainUpDown: sözel girdi, kullanıcının göz atabileceği ve aralarından seçim yapabileceği metin dizelerini görüntüler.
//DomainUpDown - SelectedItemChanged olayı ile seçili değere göre ayarlama yapıp kullanıcının göreceği şekilde istenilen label a aktarım yapılır.
//DomainUpDown ile örneğin font ailesinden 50 kaydı liste olarak getirebilme özelliği kullanılabilir.
//Load eventi ile bu componentler tetiklenebilir.
//combobox kullanıldı: seçilen fontu okudu.
//combobox - SelectedIndexChanged olayı ile seçili index değeri değiştikten sonra yapılacak işlem yazılır.
//label ile okunan font yazdırıldı.
{
	public partial class Form6 : Form
	{
		public Form6()
		{
			InitializeComponent();
		}
		private void Form6_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < 50; i++) //50 ve altı listeyi getir
			{
				domainUpDown1.Items.Add(FontFamily.Families[i].Name); //domainUpDown1 kontrolüne windows daki font listesini yüklüyoruz
			}
			//ekrandaki combobox a sistemdeki fontları yüklüyoruz 
			cbFontlar.DataSource = FontFamily.Families;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{//valuechanged olayı ile sabit font değeri değiştiğinde tipi ile label a yazdırıyor.
			label1.Font = new Font("Arial", (float)numericUpDown1.Value);
		}

		private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
		{
			label1.Font = new Font(domainUpDown1.SelectedItem.ToString(), (float)numericUpDown1.Value);
		}

		private void cbFontlar_SelectedIndexChanged(object sender, EventArgs e)
		{//seçili index değeri değiştiğinde bunu yap:
			MessageBox.Show("Seçilen Font : " + cbFontlar.SelectedItem);
		}
	}
}