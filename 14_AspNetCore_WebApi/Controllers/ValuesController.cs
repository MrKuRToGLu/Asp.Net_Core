using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _14_AspNetCore_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IActionResult Get()
        {
            List<string> strings = new List<string>();
            strings.Add("İsmail");
            strings.Add("Ali");
            strings.Add("Ekrem");

            return Ok(strings);
        }
    }
}