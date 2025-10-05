using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
	//model-views-controller: MVC -> Model Binding = Model kullanımı
	public class MVC04ModelBindingController : Controller
	{
		public IActionResult Index() //add view - empty
		{
			return View();
		}

		//added is Model - kullanici
		public IActionResult KullaniciDetay() //bu isimde view açılmalı görünm için
			//ilk sayfa açıldığında get varsayılan olarak gelir
		{
			var kullanici = new Kullanici() //nesne oluşturuldu
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

		[HttpPost] //kullanıcı detayı karşılayacak post metodu açıldı
		public IActionResult KullaniciDetay(Kullanici kullanici) //Burada belirttiğimiz kullanici nesnesi view sayfasındaki model kullanan form içerisindeki verileri model binding yöntemiyle yakalıyor.
		{
			//bu kısımda istenilirse db kayıt yapılabilir, CRUD işlemleri yapılabilir

			return View(kullanici); //Post işleminden sonra metoda parametreyle gelen kullanici nesnesini tekrar ekrana yazdır
		}

		public IActionResult AdresDetay() //add view - empty
		{
			//modelin içini boş göndermemek için nesne tanımlaması (db veri çekme) yaptık - null referance exception error solved
			var model = new Adres()
			{
				Id = 25,
				Ilce = "Keçiören",
				Sehir = "Ankara",
				AcikAdres = "Başkent"
			};
			return View(model); //model nesnesini view a yollamazsak sayfada hata almaya devam ederiz
		}
		[HttpPost]
		public IActionResult AdresDetay(Adres adres)
		{
			return View(adres);
		}

		//iki şekilde view da model oluşturmak istenirse
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
			var model = new UyeSayfasiViewModel //bu modelden nesne oluşturduk çünkü yeni modeli tanımıyor
			{
				//var olan class ları birleştirilip sunucudaki get hatası çözüldü
				Kullanici = kullanici,
				Adres = new Adres
				{
					Sehir = "Çankırı",
					Ilce = "Atkaracalar",
					AcikAdres = "Asker balıkları ılıpınar köyü"
				}
			};
			return View(model);
		}
	}
}