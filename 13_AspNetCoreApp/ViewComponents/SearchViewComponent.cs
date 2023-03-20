using Microsoft.AspNetCore.Mvc;

namespace _13_AspNetCoreApp.ViewComponents
{
    public class SearchViewComponent : ViewComponent
    {
        NorthwindContext dbContext;
        public SearchViewComponent(NorthwindContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}