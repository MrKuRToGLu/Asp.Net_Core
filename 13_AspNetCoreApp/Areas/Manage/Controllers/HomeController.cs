using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _13_AspNetCoreApp.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize(Roles = "admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
