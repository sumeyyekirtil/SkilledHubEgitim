using Microsoft.AspNetCore.Mvc;

namespace MVCEgitimi.Controllers
{
	//HtmlAndTagHelpers : razor syntax da html elementlerini oluşturmak için yardımcı olan metotlar
	//tag helpers: form - a elementlerinde kullanılır asp- ler
	public class MVC02HtmlAndTagHelpersController : Controller
	{
		public IActionResult Index() //indexe view
		{
			return View();
		}
	}
}