using Microsoft.AspNetCore.Mvc;

namespace _10_StateManagement_QueryString.Controllers
{
    public class IlanController : Controller
    {
        public IActionResult Detay(string baslik, int id)
        {
            return View();
        }
    }
}