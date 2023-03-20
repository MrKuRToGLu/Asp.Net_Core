using Microsoft.AspNetCore.Mvc;

namespace _10_StateManagementCookie.Controllers
{
    public class ProfilController : Controller
    {
        public IActionResult Index()
        {
            // cookie var mı?
            if (HttpContext.Request.Cookies["kuki"] == null)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }

    }
}
