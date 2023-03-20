using Microsoft.AspNetCore.Mvc;

namespace _2_View.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

// localhost:portno/Home
// localhost:portno/Demo