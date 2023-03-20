using Microsoft.AspNetCore.Mvc;

namespace _6_AspNetCoreBasic.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}