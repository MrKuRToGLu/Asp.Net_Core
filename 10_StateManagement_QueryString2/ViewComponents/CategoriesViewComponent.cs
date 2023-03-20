using _10_StateManagement_QueryString2.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _10_StateManagement_QueryString2.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        NorthwindContext dbContext = new NorthwindContext();
        public IViewComponentResult Invoke()
        {
            var result = dbContext.Categories.ToList();
            return View(result);
        }
    }
}