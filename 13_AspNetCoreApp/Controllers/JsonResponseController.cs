using Microsoft.AspNetCore.Mvc;

namespace _13_AspNetCoreApp.Controllers
{
    public class JsonResponseController : Controller
    {
        NorthwindContext dbContext;
        public JsonResponseController(NorthwindContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search(string key)
        {
            var result = dbContext.Products.Where(c => c.ProductName.Contains(key)).Select(c => new
            {
                c.ProductId,
                c.ProductName
            });

            return Json(result);
        }
    }
}