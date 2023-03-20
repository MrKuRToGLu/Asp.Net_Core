using Microsoft.AspNetCore.Mvc;
using _11_DependencyInjection2.models;


namespace _11_DependencyInjection2.Controllers
{
    public class HomeController : Controller
    {
        // readonly üyelerde instance tanımda veya constructor'da verilir...

        //NorthWindContext dbContext = new NorthWindContext();
        
        // instance constructor'dan gönderilecektir... (dependency injection)
        NorthWindContext dbContext;
        public HomeController(NorthWindContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult Index()
        {
            //NorthWindContext dbContext = new NorthWindContext();
            return Json(dbContext.Categories.Select(c => new
            {
                c.CategoryId,
                c.CategoryName,
                c.Description
            }).ToList());
        }

        public IActionResult Detail(int Id)
        {
            //NorthWindContext dbContext = new NorthWindContext();
            return Json(dbContext.Categories.Find(Id));
        }
    }
}