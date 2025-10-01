using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;
using System.Diagnostics;

//wwwroot klas�r�ne at�lacak yap�lar: css, js, lib-bootstrap-jquery / resim dosyalar� da burada tutulur (static dosya yap�s� : proje ile ilgili olmayan dosyalar)
//connected services : mail g�nderme servisi gibi proje ba�lama yeri
//dependences : projede kullan�lacak ba��ml� oldu�u k�t�phane , paketler
//her yeni view kendi i�eri�ini g�steren body k�sm� (dinamik k�s�m)
//yeni controller ekleme project controller - sa� t�k - add controller - empty - name - add

namespace MVCEgitimi.Controllers
{
	//Solution - Add project - MVC .net framework/.core a��l�yor
	//Models: projede kullan�lacak classlar, model kullanmadan da proje �al��t�r�labilir
	//Views: Kullan�c� g�r�n�m sayfas�
	//Controller: Projeyi �al��t�ran k�s�m kontroller. Y�netici merkez. Temel g�revi view getirmek
	//shared: payla��ml� ortak dosyalar burada tutulur
	public class HomeController : Controller //HomeController isminde class ad� home uzant�s� Controller olmak zorunda yoksa �al��maz!
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger) //dependences injection y�ntemi
		{
			_logger = logger;
		}

		public IActionResult Index() //�ndex metodu geriye de�er d�nd�ren metot IActionResult d�nd�r�r (view home k�s�mlar�)
		{
			return View(); //�ndex k�sm�na kullan�c� istek d�nd�r�rse view g�r�n�m�n� d�nd�r

			//.cshtml uzant�l� - html, c# kodlar� yaz�labilir
		}

		public IActionResult Privacy() //kullan�c� g�rmek isterse view d�ner (view home k�s�mlar� , sadece c# de�il html kodlar� da yaz�l�r, o y�zden .cshtml uzat�l�)
		{
			return View();
		}
		public IActionResult Contact() //ileti�im sayfas� : tetiklenmesi layout
		{
			//view eklenmezse sayfaya gidildi�inde sunucuda contact view was not found hatas� d�nd�r�r ve sayfa a��lmaz

			return View();//controller sayfas�nda contact metot - sa� t�k - add view - razor view - name : contact - add (hata ��z�l�r sayfa a��lm�� ve eklenmi� oldu)
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}