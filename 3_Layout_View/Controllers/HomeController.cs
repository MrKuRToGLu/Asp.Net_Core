using Microsoft.AspNetCore.Mvc;

namespace _3_Layout_View.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}