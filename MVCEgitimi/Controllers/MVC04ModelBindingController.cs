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
		public IActionResult KullaniciDetay()
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
	}
}
