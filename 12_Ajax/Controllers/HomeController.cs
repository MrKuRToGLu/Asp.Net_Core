using Microsoft.AspNetCore.Mvc;

namespace _12_Ajax.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Ogrenci> ogrencis = new List<Ogrenci>();
            ogrencis.Add(new Ogrenci { No = 4, Adi = "Ramazan" });
            ogrencis.Add(new Ogrenci { No = 5, Adi = "Ebubekir" });

            ViewBag.Ogrenciler = ogrencis;

            return View();
        }

        public IActionResult OgrenciList()
        {

            return View("Index");
        }
    }

    public class Ogrenci
    {
        public int No { get; set; }
        public string Adi { get; set; }
        public string OgrenNumarasi { get; set; }
    }
}
