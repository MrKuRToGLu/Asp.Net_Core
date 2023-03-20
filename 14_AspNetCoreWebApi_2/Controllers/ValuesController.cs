using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _14_AspNetCoreWebApi_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        string[] strings = { "Ali", "Gökhan", "Umut" };
        //public string Get(string kisi)
        //{
        //    if (Array.IndexOf(strings, kisi) > -1)
        //    {
        //        return $"aradığınız eleman listede var.";
        //    }
        //    else
        //    {
        //        return "";
        //    }
        //}
        [HttpGet("{kisi}")]
        public IActionResult Get(string kisi)
        {
            if (Array.IndexOf(strings, kisi) > -1)
            {
                return Ok($"aradığınız eleman liste var...");
            }
            else
            {
                return NotFound();
            }
        }

    }
}
