using Microsoft.AspNetCore.Mvc;

namespace _3_ViewComponent.Controllers
{
	public class SayacController : Controller
	{
		int i = 0;
		string str;
		public IActionResult Index()
		{
			str = "Bt Akademi";
			return View(i);
		}

		[HttpPost]
		// parametreiyi overload edebilmek için tanımladık..
		public IActionResult Index(string str)
		{
			i++;
			return View(i);
		}
	}
}
