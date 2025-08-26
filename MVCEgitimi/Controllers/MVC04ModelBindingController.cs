using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
	public class MVC04ModelBindingController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult KullaniciDetay() //ilk sayfa açıldığında get varsayılan olarak gelir
		{
			var kullanici = new Kullanici()
			{
				Id = 25,
				Ad = "Murat",
				Soyad = "Yılmaz",
				Email = "murat@gmail.com",
				KullaniciAdi = "muro25",
				Sifre = "muroÇeto123",
			};
			return View(kullanici); //yukarıdaki kullanici nesnesinin view da model olarak kullanılabilmesi için bu şekilde view a göndermemiz gerekir.
		}

		[HttpPost]
		public IActionResult KullaniciDetay(Kullanici kullanici) //Burada belirttiğimiz kullanici nesnesi view sayfasındaki model kullanan form içerisindeki verileri model binding yöntemiyle yakalıyor.
		{
			return View(kullanici); //Post işleminden sonra meetoda parametreyle gelen kullanici nesnesini tekrar ekrana yazdır
		}

		public IActionResult AdresDetay()
		{
			var model = new Adres()
			{
				Id = 25,
				Ilce = "Keçiören",
				Sehir = "Ankara",
				AcikAdres = "Köy"
			};
			return View(model); //model nesnesini view a yollamazsak sayfada hata almaya devam ederiz
		}
		[HttpPost]
		public IActionResult AdresDetay(Adres adres)
		{
			return View(adres);
		}
		//iki şekilde görünüm oluşturmak istenirse
		public IActionResult KullaniciAdresDetay()
		{
			var kullanici = new Kullanici()
			{
				Id = 25,
				Ad = "Murat",
				Soyad = "Yılmaz",
				Email = "murat@gmail.com",
				KullaniciAdi = "muro25",
				Sifre = "muroÇeto123",
			};
			var model = new UyeSayfasiViewModel
			{
				Kullanici = kullanici,
				Adres = new Adres
				{
					Sehir = "Çankırı",
					Ilce = "Atlakaracalar",
					AcikAdres = "Asker balıkları ılıpınar köyü"
				}
			};
			return View(kullanici);
		}
	}
}