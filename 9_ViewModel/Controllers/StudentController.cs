using _9_ViewModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace _9_ViewModel.Controllers
{
    public class StudentController : Controller
    {

        // ......Scaffolding Template.......
        public IActionResult Index()
        {
            OgrenciRepository repository = new OgrenciRepository();
            return View(repository.GetList());
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Ogrenci o)
        {
            string adi = o.Adi;
            string soyadi = o.SoyAdi;

            // verileri burada kaydediyoruz...

            return View();
        }
    }
}