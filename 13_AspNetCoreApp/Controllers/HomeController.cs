using Microsoft.AspNetCore.Mvc;

namespace _13_AspNetCoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
