using Microsoft.AspNetCore.Mvc;

namespace MVCEgitimi.Areas.Blog.Controllers
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
