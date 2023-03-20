using Microsoft.AspNetCore.Mvc;

namespace _6_AspNetCoreBasic.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            List<string> ogrenci1 = new List<string>() { "mertcan", "ramazan", "umut", "gökhan", "berat" };

            List<string> ogrenci2 = new List<string>() { "merve", "ali", "ismail" };
            //Tuple<List<string>, List<string>> model = new Tuple<List<string>, List<string>>(ogrenci1,ogrenci2);
            // veya
            Tuple<List<string>, List<string>> model = Tuple.Create(ogrenci1, ogrenci2);
            return View(model);
        }

        // asp.net core mvc'de requestler controller/action'a yapılır.. 
        public IActionResult Helpers()
        {
            return View();
        }
    }
}
