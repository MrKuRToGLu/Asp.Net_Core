using Microsoft.AspNetCore.Mvc;

namespace Giris.Controllers
{
    public class MesajController : Controller
    {
        public int Islem()
        {
            return 2 + 2;
        }

        public string Test()
        {
            return "Merhaba";
        }

        public DateTime Tarih()
        {
            return DateTime.Now;
        }
    }
}
