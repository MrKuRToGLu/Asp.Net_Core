using Microsoft.AspNetCore.Mvc;

namespace Giris.Controllers
{
    public class HomeController : Controller
    {
        // Default Action Indextir.
        //public IActionResult Index()
        //{
        //    return View();
        //}
        // bu metota httprequesti yapılabilir...
        public string Index()
        {
            return "MERHABA ARKADAŞLAR. MVC'YE GİRİŞ YAPTIK...";
        }

        public IActionResult Sayfa()
        {
            return View();
            // View(); ViewResult dönüştiplidir...Viewlar asp.net core'da html sayfalarını ifade eder. ancak bu html sayfaları .cshtml (csharphtml) uzantılıdır. 
        }

        // IActionResult => httpresponse type'dır...
        public IActionResult Veri()
        {
            List<string> kisiler = new List<string>();
            kisiler.Add("İsmail");
            kisiler.Add("Berat");
            kisiler.Add("Ekrem");
            kisiler.Add("Merve");
            //return kisiler;
            return Json(kisiler);
        }
    }
}