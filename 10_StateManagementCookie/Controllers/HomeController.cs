using Microsoft.AspNetCore.Mvc;

namespace _10_StateManagementCookie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
