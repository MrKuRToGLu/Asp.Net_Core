using Microsoft.AspNetCore.Mvc;

namespace _10_StateManagement_QueryString.Controllers
{
    public class HomeController : Controller
    {
        // Action metotlara verilen parametreler querystring olarak adlandırılır..

        // query string bir sayfadan sayfaya veya bir action'a url ile paramere gönderimidir. 

        // url?key=value
        // key parametrenin adıdır..
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Deneme(string isim)
        {
            return View();
        }

        public IActionResult Demo(string isim)
        {
            return View();
        }

        public IActionResult Sayfa(string isim, string soyisim)
        {
            return View();
        }
    }
}