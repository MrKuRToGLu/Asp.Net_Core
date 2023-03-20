using Microsoft.AspNetCore.Mvc;
namespace _5_WebLifeCycle.Controllers
{
    public class HomeController : Controller
    {
        int sayac = 0;
        public IActionResult Index()
        {
            return View(sayac);
        }

        public IActionResult Arttir()
        {
            sayac++;
            return View("Index", sayac);
        }
    }
}