using _11_DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace _11_DependencyInjection.Controllers
{
    public class OgrenciController : Controller
    {
        IOgrenci ogrenci;
        public OgrenciController(IOgrenci ogrenci)
        {
            this.ogrenci = ogrenci;
        }

        public IActionResult Index()
        {
            #region MyRegion
            IOgrenci ogrenci = new Tembeller();
            ogrenci.List(); // tembeller listesini döner..

            IOgrenci ogrenci1 = new Caliskanlar();
            ogrenci1.List(); // caliskanlar listenini döner...

            // dependency injection örnek
            var tembeller = new Tembeller();
            var caliskanlar = new Caliskanlar();

            EnjekteMetot(tembeller);
            EnjekteMetot(caliskanlar);
            #endregion

            List<string> list = ogrenci.List();
            return View(list);
        }

        void EnjekteMetot(IOgrenci ogrenciler)
        {
            ogrenciler.List();
        }

    }
}
