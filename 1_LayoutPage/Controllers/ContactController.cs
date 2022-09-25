using _1_LayoutPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace _1_LayoutPage.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}


		[HttpPost]
		public IActionResult Index(ContactModel model)
		{
			return View();
		}

	}
}
