using Microsoft.AspNetCore.Mvc;

namespace _10_StateManagementCookie.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        // FormCollection => request yapılan form'dan inputların name göre valueları alınır

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            string userName = form["uname"];
            string pwd = form["psw"];

            if (userName == "admin" && pwd == "123")
            {
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddDays(1); // Kukinin süresi 1 gün

                HttpContext.Response.Cookies.Append("kuki", userName, options); // tarayıcıa kuki set edilir...

                // Profil'e bilgileri dön..
                return RedirectToAction("Index", "Profil");
            }
            else
            {
                return View();
            }
        }

        public IActionResult LogOut()
        {
            // cookiyi sil
            //
            //
            HttpContext.Response.Cookies.Delete("kuki");
            return RedirectToAction("Index", "Home");
        }
    }
}