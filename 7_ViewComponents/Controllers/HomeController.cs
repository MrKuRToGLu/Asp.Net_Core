using Microsoft.AspNetCore.Mvc;

namespace _7_ViewComponents.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
