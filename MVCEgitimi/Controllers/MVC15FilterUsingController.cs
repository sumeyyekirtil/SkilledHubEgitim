﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Filters;
using MVCEgitimi.Models;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MVCEgitimi.Controllers
{
	public class MVC15FilterUsingController : Controller
	{
		private readonly UyeContext _context;

		public MVC15FilterUsingController(UyeContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}
		[UserControl]
		public IActionResult UyelikBilgilerim()
		{//UserControl sınıfında filter ile override metot kullandığımız içi bu kısımda kod sadeliğine yapılır
			var id = HttpContext.Session.GetInt32("kullaniciId");
			//if (id is not null)
			//{
			//	var kullanici = _context.Uyeler.Find(id);
			//	if (kullanici != null)
			//	{
			//		return View(kullanici);
			//	}
			//}
			var kullanici = _context.Uyeler.Find(id);
			return View(kullanici);
		}
		[UserControl] //aşağıdaki action metoduna UserControl filter içinde uyguladığımız kontrolü yap.
		[Authorize] //kullanıcı sisteme girişini kontrol eden metot
		public IActionResult Edit()
		{
			var id = HttpContext.Session.GetInt32("kullaniciId");
			var kullanici = _context.Uyeler.Find(id);
			return View(kullanici);
		}
		[HttpPost]
		[UserControl]
		[Authorize]
		public IActionResult Edit(Uye uye)
		{
			_context.Uyeler.Update(uye);
			_context.SaveChanges();
			return RedirectToAction("UyelikBilgilerim");
		}

		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(string kullaniciAdi, string sifre) //await metodunu kullanabilmek için asenkron işlemler yapılmasını sağlar (make)
		{
			var kullanici = _context.Uyeler.FirstOrDefault(u => u.KullaniciAdi == kullaniciAdi && u.Sifre == sifre);
			if (kullanici != null)
			{
				HttpContext.Session.SetInt32("kullaniciId", kullanici.Id);
				var haklar = new List<Claim>() //kullanıcı hakları tanımladık
				{
					new(ClaimTypes.Email, kullanici.Email), //claim = hak (kullanıcıya tanımlanan haklar)
						new(ClaimTypes.Role, "Admin")
				};
				var kullaniciKimligi = new ClaimsIdentity(haklar, "Login"); //kullanıcı için bir kimlik oluşturduk
				ClaimsPrincipal claimsPrincipal = new(kullaniciKimligi); //bu sınıftan bir nesne oluşturup bilgilerde saklı haklar ile kural oluşturulabilir
				await HttpContext.SignInAsync(claimsPrincipal); //yukarıdaki yetkilerle sisteme giriş yaptık
				return RedirectToAction("Edit");
			}
			return View();
		}

		public IActionResult Logout()
		{
			HttpContext.SignOutAsync(); //kullanıcı oturumunu kapat
			HttpContext.Session.Clear(); //sessionları temizle
			return View("Index"); //yönlendir
		}
	}
}
