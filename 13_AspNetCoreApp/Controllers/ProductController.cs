using Microsoft.AspNetCore.Mvc;

namespace _13_AspNetCoreApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
