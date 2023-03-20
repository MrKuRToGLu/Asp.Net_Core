using Microsoft.AspNetCore.Mvc;

namespace _10_StateManagement_Session.Controllers
{
    public class HomeController : Controller
    {
        int sayac;
        //[HttpGet]
        public IActionResult Index()
        {
            sayac++;
            return View(sayac);
        }

        [HttpPost]
        public IActionResult Index(string temp)
        {
            // session => default 20 dakika timeout süresi vardır. client'a özel bilgiler burada saklanır..

            // Not :  sessin kullanabilmek için program.cs dosyasında AddSession  ve UseSession metotları tetiklenmelidir...

            // session'da veri var mı?
            //if (HttpContext.Session.GetInt32("syc") != null)
            if (HttpContext.Session.GetInt32("syc").HasValue)
            {
                sayac = (int)HttpContext.Session.GetInt32("syc");
            }
            sayac++;

            HttpContext.Session.SetInt32("syc", sayac); // syc isimli bir session oluştur ve değeri set et...

            return View(sayac);
        }
    }
}