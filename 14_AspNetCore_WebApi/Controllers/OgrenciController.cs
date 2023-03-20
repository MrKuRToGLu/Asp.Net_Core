using _14_AspNetCore_WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _14_AspNetCore_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgrenciController : ControllerBase
    {
        List<Ogrenci> ogrencis = new List<Ogrenci>();
        public OgrenciController()
        {
            ogrencis.Add(new Ogrenci { Id = 1, Adi = "Ekrem", SoyAdi = "Yıldırım" });
            ogrencis.Add(new Ogrenci { Id = 2, Adi = "Ali", SoyAdi = "Yılmaz" });
            ogrencis.Add(new Ogrenci { Id = 3, Adi = "İsmail", SoyAdi = "Kuroğlu" });
            ogrencis.Add(new Ogrenci { Id = 4, Adi = "Cemre", SoyAdi = "Aztekin" });
        }

        public IActionResult Get()
        {
            return Ok(ogrencis);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Ogrenci ogr = ogrencis.FirstOrDefault(c => c.Id == id);

            if (ogr != null)
                return Ok(ogr); // 200 döner..
            else
                return NotFound("Kayıt Bulunamadı"); // 404 döner....
        }

        [HttpPost]
        public IActionResult Kaydet(Ogrenci ogr)
        {
            return Ok("Kaydetme İşlemi Başarılı");
        }
    }
}