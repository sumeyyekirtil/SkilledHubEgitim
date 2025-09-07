using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
	//Get açıldığında gelen gönderim yolu, Post tıklandığındaki gönderim yoludur
	//Get metodunda liste tanımlanıp gösterime açılır
	//Post metodu olan kısma yapılacak işlem detayı girilir
	public class MVC06CRUDController : Controller
	{
		private readonly UyeContext _context;

		public MVC06CRUDController(UyeContext context)
		{
			_context = context;
		}

		// GET: MVC06CRUDController
		public ActionResult Index()
		{
			return View(_context.Uyeler);
		}

		// GET: MVC06CRUDController/Details/5
		public ActionResult Details(int id)
		{
			var kayit = _context.Uyeler.Find(id); //id ye ulaşıp kayıt detaylarını yazdırma işlemi
			return View(kayit);
		}

		// GET: MVC06CRUDController/Create

		//InvalidOperationException: The view 'Create' was not found.The following locations were searched:/Views/MVC06CRUD/Create.cshtml  /Views/Shared/Create.cshtml hatası çözümü ->>>
		public ActionResult Create()
		{
			return View();
		}

		// POST: MVC06CRUDController/Create
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

		// GET: MVC06CRUDController/Edit/5
		public ActionResult Edit(int id)
		{
			var kayit = _context.Uyeler.Find(id); //uyeler tablosundan route dan gelen id ile eşleşen kaydı bul ve ekrana gönder.
			return View(kayit);
		}

		// POST: MVC06CRUDController/Edit/5
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

		// GET: MVC06CRUDController/Delete/5
		public ActionResult Delete(int id)
		{
			var kayit = _context.Uyeler.Find(id); //id ye ulaşıp kayıt detaylarını yazdırma işlemi
			return View(kayit);
		}

		// POST: MVC06CRUDController/Delete/5
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