using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace _10_StateManagement_QueryString2.Controllers
{
    public class ProductController : Controller
    {
        NorthwindContext dbContext = new NorthwindContext();
        public IActionResult Index(int CategoryId)
        {
            var result = dbContext.Products.Where(c => c.CategoryId == CategoryId).ToList();
            return View(result);
        }

        public IActionResult Detail(int ProductId, string ProductName)
        {
            var product = dbContext.Products.Find(ProductId);

            List<int> productIds = new List<int>();

            if (HttpContext.Request.Cookies["prodList"] != null) // cookie varsa...
            {
                string val = HttpContext.Request.Cookies["prodList"];
                productIds = JsonSerializer.Deserialize<List<int>>(val); // cooki'deki idleri nesnemize dönüştürüyoruz
            }
            if (!productIds.Contains(ProductId)) // daha önce listeye eklemediysek
                productIds.Add(ProductId);

            // listeyi json'a convert ediyoruz...
            // JsonSerializer => System.Text.Json namespace içerisinde
            string prodList = JsonSerializer.Serialize(productIds);

            HttpContext.Response.Cookies.Append("prodList", prodList);

            return View(product);
        }
    }
}