using Microsoft.AspNetCore.Mvc;

namespace _13_AspNetCoreApp.Controllers
{
    public class HtmlResponseController : Controller
    {
        NorthwindContext dbContext;
        public HtmlResponseController(
            NorthwindContext dbContext)
        {
            this.dbContext = dbContext; 
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(string key)
        {
            var result = dbContext.Products.Where(c => c.ProductName.Contains(key)).ToList();
            return PartialView("_SearchHtmlResult", result);
        }
    }
}
