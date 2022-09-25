using Microsoft.AspNetCore.Mvc;

namespace _3_ViewComponent.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
