using Microsoft.AspNetCore.Mvc;

namespace _11_DependencyInjection.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
