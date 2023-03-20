using Microsoft.AspNetCore.Mvc;

namespace _6_AspNetCore_LifreCycle_Basic.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}