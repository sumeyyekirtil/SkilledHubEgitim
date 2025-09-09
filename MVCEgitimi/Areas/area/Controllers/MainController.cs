using Microsoft.AspNetCore.Mvc;

namespace MVCEgitimi.Areas.area.Controllers
{
	[Area("area")] //bu controller ın admin areası altında çalışacağını bildiriyoruz
	public class MainController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
