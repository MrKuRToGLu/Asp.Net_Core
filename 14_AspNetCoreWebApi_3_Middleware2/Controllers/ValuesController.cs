using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _14_AspNetCoreWebApi_3_Middleware2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("Merhaba Ben Kaynak...");
        }
    }
}