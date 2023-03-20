using Microsoft.AspNetCore.Mvc;

namespace _10_StateManagement_QueryString.Controllers
{
    public class DemoController : Controller
    {

        // Action metotlara verilen parametreler querystring olarak adlandırılır..
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
