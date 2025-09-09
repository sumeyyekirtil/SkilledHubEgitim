using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Areas.area.Controllers
{
	[Area("area")] //bu controller ın admin areası altında çalışacağını bildiriyoruz --404 hatası için
	public class UyelerController : Controller
	{
		private readonly UyeContext _context;

		public UyelerController(UyeContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View(_context.Uyeler);
		}

		public ActionResult Details(int id)
		{
			var kayit = _context.Uyeler.Find(id); //id ye ulaşıp kayıt detaylarını yazdırma işlemi
			return View(kayit);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Uye collection)
		{
			try
			{
				_context.Uyeler.Add(collection);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		public ActionResult Edit(int id)
		{
			var kayit = _context.Uyeler.Find(id); //uyeler tablosundan route dan gelen id ile eşleşen kaydı bul ve ekrana gönder.
			return View(kayit);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, Uye collection)
		{
			try
			{
				_context.Uyeler.Update(collection); //ekrandan gelen modeli veritabanındaki kaydı değiştirecek şekilde ayarla
				_context.SaveChanges(); //değişiklikleri db kaydet

				return RedirectToAction(nameof(Index)); //Index isimli action metoduna yönlendir
			}
			catch
			{
				ModelState.AddModelError("", "Hata Oluştu!"); //hata oluşursa yazdır
			}
			return View(collection);
		}
		public ActionResult Delete(int id)
		{
			var kayit = _context.Uyeler.Find(id); //id ye ulaşıp kayıt detaylarını yazdırma işlemi
			return View(kayit);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, Uye collection)
		{
			try
			{
				_context.Uyeler.Remove(collection); //ekrandan gelen üye nesnesini silinecek olarak işaretle
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
