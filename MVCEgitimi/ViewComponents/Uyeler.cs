using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models; //ViewComponent kütüphanesi

namespace MVCEgitimi.ViewComponents
{
	public class Uyeler : ViewComponent
	{
		private readonly UyeContext _context;

		public Uyeler(UyeContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{
			return View(_context.Uyeler); //bu sınıf ViewComponent yapısı sayesinde geriye View gönderebiliyor
		}
	}
}
