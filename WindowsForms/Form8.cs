using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//MENUSTRIP - CONTEXTMENUSTRIP - RICHTEXTBOX
namespace WindowsForms
{//menustrip: iç içe açılan alt menüsü olan menu sistemi yapar.
 //backend de tıklanınca gelir arkada saklı olarak kalır ilk satır hariç
 //richtextbox: smart tag - multiline işaretlendi
 //contextmenustrip: Açılır menü,üstüne tıklanmadan backend de görülmez.
 //contextmenustrip-property: contextmenustrip none değil strip olanı işaretliyoruz.
 //Contextmenü tıklandığında işlem yaptırabilmek için istediğimiz butonu çift click - eventi oluşturup
	public partial class Form8 : Form
	{
		public Form8()
		{
			InitializeComponent();
		}

		private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit(); //uygulamadan çık
		}

		private void seçToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.SelectAll(); //hepsini seç
		}

		private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.Copy(); //kopyala
		}

		private void kesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.Cut(); //kes
		}

		private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.Paste(); //yapıştır
		}

		private void silToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.Clear(); //temizle
		}
	}
}