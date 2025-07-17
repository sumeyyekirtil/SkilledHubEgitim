using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEntityFramework
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		UrunDbModel context = new UrunDbModel();
		private void Form1_Load(object sender, EventArgs e)
		{
			dgvUrunListesi.DataSource = context.Products.ToList(); //ef ile vt daki ürünleri çekme
		}
	}
}
