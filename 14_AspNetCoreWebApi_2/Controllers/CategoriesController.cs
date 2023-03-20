using _14_AspNetCoreWebApi_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _14_AspNetCoreWebApi_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        AppDbContext dbContext;
        public CategoriesController(AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var list = dbContext.Categories.ToList();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var category = dbContext.Categories.Find(id);
            if (category != null)
                return Ok(category);
            else
                return NotFound();
        }

        [HttpPost]
        public IActionResult Post(Category model)
        {
            dbContext.Categories.Add(model);
            return Ok("İşlem Başarılı");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,Category model)
        {
            var category = dbContext.Categories.Find(id);
            if (category == null)
                return NotFound();

            category.CategoryName = model.CategoryName;
            category.Description = model.Description;

            dbContext.SaveChanges();// değişikliği veri tabanına yansıt...
            return Ok("İşlem Başarılı");
        }
    }
}