using Microsoft.AspNetCore.Mvc;

namespace _10_StateManagement_QueryString2.Controllers
{
    public class HomeController : Controller
    {
        NorthwindContext dbContext = new NorthwindContext();
        public IActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel();

            // en son gelenler...
            vm.Yeniler = dbContext.Products.Take(10).OrderByDescending(c => c.UnitsInStock).ToList();

            //bitmek üzere olanlar...
            vm.Azalanlar = dbContext.Products.Take(10).OrderBy(c => c.UnitsInStock).ToList();


            return View(vm);
        }
    }
}
