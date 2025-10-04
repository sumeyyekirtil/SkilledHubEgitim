using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
	//Ekrandan alınan veriyi arka plana - arkadan alınan veriyi ekrana gönderme işlemleri
	//controller : backend - view: frontend
	public class MVC03DataTransferController : Controller
		//bir metodun üzerinde post yazmıyorsa varsayılan tipi get olur.
	{
		public IActionResult Index(string txtAra) //razor view add
			//!!!string değişkenin adının txtAra olması ön yüzdeki textbox ın name değeriyle eşleştirilmesi için. Farklı isim verilirse veri yakalanamaz.
		{
			//Mvc de temel olarak 3 türde view a veri yollama yapısı var 
			//Örneğin veritabanından ürün bilgisini çekip ekrana yollamak için

			//1-ViewBag : Tek kullanımlık Ömrü Var
			ViewBag.UrunKategorisi = "Bilgisiyar"; //dinamic
			
			//2 - ViewData : Tek Kullanımlık Ömrü Var
			var urunListesi = new List<Urun>
			{
				//models - add - urun class - add properties and error is solved!
				new Urun() { Adi = "Oyun Bilgisayarı", Fiyati = 49000, Stok = 5 },
				new Urun() { Adi = "Laptop", Fiyati = 29000, Stok = 8 },
				new Urun() { Adi = "İş İstasyonu", Fiyati = 99000, Stok = 2 }
			};
			ViewData["Urunler"] = urunListesi;
			
			//3- TempData : 2 kullanımlık Ömrü Var : Sayfa Post olursa da kullanılabilir
			TempData["UrunBilgi"] = "Toplam " + urunListesi.Count + "Ürün Bulundu..";

			ViewBag.GetVerisi = txtAra; //viewda gönderilen değer
			return View();
		}

		[HttpPost] 
		//Aşağıdaki metot ekrandan gelecek post isteklerinde çalışır
		public IActionResult Index(string txtUrunAdi, string ddlKategori, string rbOnay, bool cbOnay, IFormCollection formCollection) //() içine viewda yazılan aynı ad lar ile veri almak için tanımlama yapılır
			//checkbox: bool türünde yakalanır
		{
			var urunListesi = new List<Urun>
			{
				new Urun() { Adi = "Oyun Bilgisayarı", Fiyati = 49000, Stok = 5 },
				new Urun() { Adi = "Laptop", Fiyati = 29000, Stok = 8 },
				new Urun() { Adi = "İş İstasyonu", Fiyati = 99000, Stok = 2 }
			};
			ViewData["Urunler"] = urunListesi;

			ViewBag.Baslik1 = "1.Yöntem Parametreyle Veri Yakalama";
			ViewBag.Mesaj1 = "Textbox değeri : " + txtUrunAdi;
			ViewBag.Mesaj2 = "Dropdown değeri : " + ddlKategori;
			ViewBag.Mesaj3 = "cbOnay değeri : " + cbOnay;
			ViewBag.Mesaj3 += " - rbOnay değeri : " + rbOnay; // += ile bir önceki onaya ekleme yapıp aynı satırda gösterildi

			//2. yöntem ile veri göndermek için bunun için metot() kısmına formCollection nesnesi eklenmeli
			ViewBag.Baslik1 = "2.Yöntem IFormCollection ile Veri Yakalama";
			ViewBag.Mesaj1 = "Textbox değeri : " + formCollection["txtUrunAdi"];
			ViewBag.Mesaj2 = "Dropdown değeri : " + formCollection["ddlKategori"];
			ViewBag.Mesaj3 = "cbOnay değeri : " + formCollection["cbOnay"][0]; //ilk index değeri elde etmek için 0. değer alındı
			ViewBag.Mesaj3 += " - rbOnay değeri : " + formCollection["rbOnay"][0];

			//3.yöntem ile veri göndermek için request form (istekten gelen form elementini getirme)
			ViewBag.Baslik1 = "3.Yöntem Request Form ile Veri Yakalama"; //istenilen formdaki şu veriyi getir
			ViewBag.Mesaj1 = "Textbox değeri : " + Request.Form["txtUrunAdi"];
			ViewBag.Mesaj2 = "Dropdown değeri : " + Request.Form["ddlKategori"];
			ViewBag.Mesaj3 = "cbOnay değeri : " + Request.Form["cbOnay"][0]; //ilk index değeri elde etmek için 0. değer alındı
			ViewBag.Mesaj3 += " - rbOnay değeri : " + Request.Form["rbOnay"][0];
			return View();
		}
	}
}