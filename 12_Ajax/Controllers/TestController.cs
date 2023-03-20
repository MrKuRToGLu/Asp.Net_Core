using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace _12_Ajax.Controllers
{
    public class TestController : Controller
    {
        //[HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int deger)
        {
            deger++;
            return Json(deger);
        }

        [HttpPost]
        public IActionResult Kisi()
        {
            Ogrenci ogr = new Ogrenci();
            ogr.No = 23321;
            ogr.Adi = "Burak";


            //Json konfigurasyonunu program.cs'den yapıyoruz...
            //JsonSerializerOptions options = new JsonSerializerOptions();
            //options.PropertyNamingPolicy = null; // camel-case isimlendirme devre dışı bırakılır....
            //return Json(ogr, options);


            return Json(ogr);
        }

        public IActionResult Kisiler()
        {
            List<Ogrenci> ogrencis = new List<Ogrenci>();
            ogrencis.Add(new Ogrenci { No = 1, Adi = "Ebubekir" });
            ogrencis.Add(new Ogrenci { No = 2, Adi = "Cemre" });
            ogrencis.Add(new Ogrenci { No = 3, Adi = "Ali" });
            ogrencis.Add(new Ogrenci { No = 4, Adi = "Gökhan" });

            //JsonSerializerOptions options = new JsonSerializerOptions();
            //options.PropertyNamingPolicy = null;
            //return Json(ogrencis,options);
            return Json(ogrencis);
        }
    }
}