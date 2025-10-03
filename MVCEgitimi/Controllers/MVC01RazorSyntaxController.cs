using Microsoft.AspNetCore.Mvc;

namespace MVCEgitimi.Controllers
{
	//yeni controller ekleme project controller - sağ tık - add controller - empty - name - add
	//varsayılan sayfa aksi yazılmaz ise index tir
	public class MVC01RazorSyntaxController : Controller
	{
		public IActionResult Index() //add - empty razor
		{
			return View();
		}
	}
}