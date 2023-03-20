using Microsoft.AspNetCore.Mvc;

namespace _2_View.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Sayfa()
        {
            // Not=> View() metodu default ActionName.cshtml dosyasını döner
            //return View(); //Sayfa.cshtml döner...
            return View("biz"); // biz.cshtml döner...
        }

        // parametre alan actionmetot
        // Url => Home/Eksin?tip=admin|user
        public IActionResult Eksin(string tip)
        {
            if (tip == "admin")
                return View(); // View dön
            else if (tip == "user")
                return Json("Hoş Geldin User"); // json dön
            else
                return RedirectToAction("Index"); // Action dön
        }



    }
}
