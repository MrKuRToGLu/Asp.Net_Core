using Microsoft.AspNetCore.Mvc;

namespace _7_ViewComponents.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
