﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
namespace WindowsForms
{
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
		}

		private void btnGiris_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
			{
				MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçılemez!", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Question);
			}
			else if(string.IsNullOrEmpty(txtSifre.Text))
			{
				MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçılemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
			}
			else
			{
				string veritabanindakiKullanici = "Admin", veritabanindakiSifre = "Admin123";
				if (txtKullaniciAdi.Text == veritabanindakiKullanici && txtSifre.Text == veritabanindakiSifre)
				{
					this.Hide();//bu formu gizle 
					Form4 form4 = new Form4();
					form4.ShowDialog();
				}
				else
				{
					MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);//giriş başarısızsa uyarı penceresi göster
				}
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(cbKategoriler.SelectedItem + "Kategorisine " + txtUrunAdi.Text + "Ürünü Eklendi!");
		}
	}
}