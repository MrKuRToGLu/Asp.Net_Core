using _14_AspNetCoreWebApi_4_JwtToken.Models.Entites;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _14_AspNetCoreWebApi_4_JwtToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        NorthwindContext dbContext;
        public ProductController(
            NorthwindContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Get()
        {
            return Ok(dbContext.Products.ToList());
        }
    }
}