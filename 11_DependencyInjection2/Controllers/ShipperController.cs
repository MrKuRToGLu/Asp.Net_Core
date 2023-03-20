using Microsoft.AspNetCore.Mvc;
using _11_DependencyInjection2.models;

namespace _11_DependencyInjection2.Controllers
{
    public class ShipperController : Controller
    {
        NorthWindContext dbContext;
        public ShipperController(NorthWindContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult Index()
        {
            return Json(dbContext.Shippers.ToList());
        }
    }
}