using Microsoft.AspNetCore.Mvc;

namespace MVCEgitimi.Controllers
{
	public class MVC13StringFormatController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.MusteriNo = string.Format("{M:D6}", 1); //başına m değeri ekleyip 6 karakterli olsun numarası 1 olsun
			ViewBag.SaticiNo = string.Format("{S:D6}", 218);
			return View();
		}
	}
}
