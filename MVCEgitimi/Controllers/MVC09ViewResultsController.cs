﻿using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
	public class MVC09ViewResultsController : Controller
	{
		private readonly UyeContext _context;

		public MVC09ViewResultsController(UyeContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult FarkliViewDondur() //action
		{
			return View("Index"); //ındex isimli ekranı döndürsün denilebilir
		}
		public IActionResult Yonlendir()
		{
			//return Redirect("/Home"); //kullanıcıyı bu adrese yönlendir
			return Redirect("https://www.google.com/ome"); //işlem sonunda kullanıcıyı başka bir sitede de yönlendirebiliriz
		}

		public IActionResult ActionaYonlendir()
		{
			//return RedirectToAction("Index");
			//return RedirectToAction("Yonlendir"); //Yonlendir action ı tetikle
			return RedirectToAction("Index", "MVC06CRUD"); //action ve controller 
		}

		public RedirectToRouteResult RouteYonlendir()
		{
			return RedirectToRoute("Default", new { controller = "Home", action = "Index", id = 18 });
		}

		public PartialViewResult KategorileriGetirPartial() //action
		{
			return PartialView("_PartialMenu"); //ındex isimli ekranı döndürsün denilebilir
		}

		public JsonResult JsonDondur() //action
		{
			var kullanicilar = _context.Uyeler.ToList();
			return Json(kullanicilar); //ındex isimli ekranı döndürsün denilebilir
		}

		public ContentResult XmlContentResult() //action
		{
			var kullanicilar = _context.Uyeler.ToList();
			var xml = "<kullanicilar>";
			foreach (var item in kullanicilar)
			{
				xml += $@"<kullanici>
					   <Id>{item.Id}</Id>
					   <Ad>{item.Ad}</Ad>
					   <Soyad>{item.Soyad}</Soyad>
					   <TcKimlikNo>{item.TcKimlikNo}</TcKimlikNo>
					   <DogumTarihi>{item.DogumTarihi}</DogumTarihi>
                       </kullanici>";
			}
			xml += "</kullanicilar>";
			return Content(xml, "application/xml"); //ındex isimli ekranı döndürsün denilebilir
		}
	}
}