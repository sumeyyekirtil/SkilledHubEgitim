using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;
using System.Diagnostics;

//www root klas�r�ne at�lacak yap�lar
//controllers yap�s� mvc �al��t�r�r (ara� �of�r� gibi)
//connected services : mail g�nderme servisi gibi proje ba�lama yeri
//dependences : projede kullan�lacak ba��ml� oldu�u k�t�phane , paketler
//her yeni view kendi i�eri�ini g�steren body k�sm� (dinamik k�s�m)
//yeni controller ekleme project controller - sa� t�k - add controller - empty - name - add

namespace MVCEgitimi.Controllers
{
	public class HomeController : Controller //HomeController isminde class ad� home uzant�s� Controller olmak zorunda yoksa �al��maz!
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger) //dependences injection y�ntemi
		{
			_logger = logger;
		}

		public IActionResult Index() //�ndex metodu geriye de�er d�nd�ren metot IActionResult d�nd�r�r (view home k�s�mlar�)
		{
			return View();
		}

		public IActionResult Privacy() //kullan�c� g�rmek isterse view d�ner (view home k�s�mlar� , sadece c# de�il html kodlar� da yaz�l�r, o y�zden .cshtml uzat�l�)
		{
			return View();
		}
		public IActionResult Contact() //ileti�im sayfas� : tetiklenmesi layout
		{
			return View();//controller sayfas�nda contact metot - sa� t�k - add view - razor view - name : contact - add (hata ��z�l�r sayfa a��lm�� ve eklenmi� oldu)
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}