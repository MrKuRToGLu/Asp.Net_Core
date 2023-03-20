using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace _10_StateManagement_QueryString2.ViewComponents
{
    public class SonGezilenlerViewComponent : ViewComponent
    {
        NorthwindContext dbContext = new NorthwindContext();

        public IViewComponentResult Invoke()
        {
            List<Product> products;
            if (HttpContext.Request.Cookies["prodList"] != null)
            {
                List<int> ids = JsonSerializer.Deserialize<List<int>>(HttpContext.Request.Cookies["prodList"]);

                //id'nin içerisinde productId geçelenleri getir...
                products = dbContext.Products.Where(c => ids.Contains(c.ProductId)).ToList();
            }
            else
                products = new List<Product>();

            return View(products);
        }
    }
}
