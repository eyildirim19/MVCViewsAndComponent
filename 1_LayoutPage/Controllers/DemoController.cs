using Microsoft.AspNetCore.Mvc;

namespace _1_LayoutPage.Controllers
{
	public class DemoController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
