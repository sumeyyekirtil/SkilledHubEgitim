using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAdoNet
{
	public partial class Kategoriler : Form
	{
		public Kategoriler()
		{
			InitializeComponent();
		}

		private void dgvKategoriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Kategoriler_Load(object sender, EventArgs e)
		{
			dgvKategoriler.DataSource = CategoryDal.GetDataTable("select * from Kategoriler");
		}
	}
}
