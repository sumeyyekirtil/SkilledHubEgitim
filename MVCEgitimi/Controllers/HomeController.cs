using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;
using System.Diagnostics;

//www root klasörüne atýlacak yapýlar
//controllers yapýsý mvc çalýþtýrýr (araç þoförü gibi)
//connected services : mail gönderme servisi gibi proje baðlama yeri
//dependences : projede kullanýlacak baðýmlý olduðu kütüphane , paketler
//her yeni view kendi içeriðini gösteren body kýsmý (dinamik kýsým)
//yeni controller ekleme project controller - sað týk - add controller - empty - name - add

namespace MVCEgitimi.Controllers
{
	public class HomeController : Controller //HomeController isminde class adý home uzantýsý Controller olmak zorunda yoksa çalýþmaz!
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger) //dependences injection yöntemi
		{
			_logger = logger;
		}

		public IActionResult Index() //ýndex metodu geriye deðer döndüren metot IActionResult döndürür (view home kýsýmlarý)
		{
			return View();
		}

		public IActionResult Privacy() //kullanýcý görmek isterse view döner (view home kýsýmlarý , sadece c# deðil html kodlarý da yazýlýr, o yüzden .cshtml uzatýlý)
		{
			return View();
		}
		public IActionResult Contact() //iletiþim sayfasý : tetiklenmesi layout
		{
			return View();//controller sayfasýnda contact metot - sað týk - add view - razor view - name : contact - add (hata çözülür sayfa açýlmýþ ve eklenmiþ oldu)
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}