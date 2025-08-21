using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
	public class MVC03DataTransferController : Controller
	{
		public IActionResult Index(string txtAra) //string değişkenin adının txtAra olması ön yüzdeki textbox ın name değeriyle eşleştirilmesi için.Farklı isim verilirse veri yakalanamaz.
		{
			//Mvc de temel olarak 3 türde view a veri yollama yapısı var 
			//Örneğin veritabanından ürün bilgisini çekip ekrana yollamak için

			//1-ViewBag : Tek kullanımlık Ömrü Var
			ViewBag.UrunKategorisi = "Bilgisiyar"; //dinamic
			
			//2 - ViewData : Tek Kullanımlık Ömrü Var
			var urunListesi = new List<Urun>
			{
				new Urun() { Adi = "Oyun Bilgisayarı", Fiyati = 49000, Stok = 5 },
				new Urun() { Adi = "Laptop", Fiyati = 29000, Stok = 8 },
				new Urun() { Adi = "İş İstasyonu", Fiyati = 99000, Stok = 2 },
			};
			ViewData["Urunler"] = urunListesi;
			
			//3- TempData : 2 kullanımlık Ömrü Var
			TempData["UrunBilgi"] = "Toplam " + urunListesi.Count + "Ürün Bulundu..";

			ViewBag.GetVerisi = txtAra;
			return View();
		}
	}
}