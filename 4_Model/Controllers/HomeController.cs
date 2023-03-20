using Microsoft.AspNetCore.Mvc;

namespace _4_Model.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<string> kisiler = new List<string>();
            kisiler.Add("İsmail");
            kisiler.Add("Havva");
            kisiler.Add("Merve");
            kisiler.Add("Ramazan");

            return View(kisiler); // View'a modeli gönder..
        }
    }
}
