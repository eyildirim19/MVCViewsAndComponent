using Microsoft.AspNetCore.Mvc;

namespace _1_LayoutPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
