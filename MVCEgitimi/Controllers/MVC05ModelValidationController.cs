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
			return View(uye);
		}
	}
}
