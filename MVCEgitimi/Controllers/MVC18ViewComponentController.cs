using Microsoft.AspNetCore.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
	public class MVC18ViewComponentController : Controller
	{
		private readonly UyeContext _context;

		public MVC18ViewComponentController(UyeContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View(_context.Uyeler);
		}
	}
}
