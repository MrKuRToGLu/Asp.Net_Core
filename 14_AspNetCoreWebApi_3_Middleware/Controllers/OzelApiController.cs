using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _14_AspNetCoreWebApi_3_Middleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OzelApiController : ControllerBase
    {
        public IActionResult Get(string isim, string pwd)
        {
            if (isim == "ismail" && pwd == "123")
            {
                return Ok("Merhaba kaynağa eriştiniz. Tebrikler....");
            }
            else
            {
                return Unauthorized("Dataya Erişim Yetkiniz Yoktur...");
            }
        }
    }
}
