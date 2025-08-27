using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
	public class MVC05ModelValidationController : Controller
	{
		public IActionResult Index() //controller
		{
			return View();
		}

		public IActionResult YeniUye() //Action
		{
			return View();
		}
		[HttpPost]
		public IActionResult YeniUye(Uye uye) //Action
		{
			if (ModelState.IsValid) //Eğer modeldeki validasyon kurallarına uyulmuşsa, tersi için !ModelState.IsValid kullanılır
			{
				//kayıt ekle-güncelle-sil vb
			}
			else
			{
				ModelState.AddModelError("", "Lütfen Tüm Zorunlu Doldurunuz!"); //Ekrandaki validasyonkontrol alanına mesaj gönderebiliyoruz
			}
				return View(uye);
		}
	}
}