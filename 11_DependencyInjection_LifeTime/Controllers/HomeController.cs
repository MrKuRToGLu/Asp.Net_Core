using Microsoft.AspNetCore.Mvc;
using _11_DependencyInjection_LifeTime.Models;

namespace _11_DependencyInjection_LifeTime.Controllers
{
    public class HomeController : Controller
    {
        MyClass myClass;
        MyClass myClass2;
        public HomeController(MyClass myClass,
            MyClass myClass2)
        {
            this.myClass = myClass;
            this.myClass2 = myClass2;
        }

        public IActionResult Index()
        {
            #region instance alındığında değerlerin incelenmesi
            //MyClass my = new MyClass();
            //string deger = my.uid.ToString();
            //MyClass myClass = my;
            //string deger1 = myClass.uid.ToString();
            //MyClass my1 = new MyClass();
            //string deger3 = my1.uid.ToString();
            #endregion


            // Küçük veri işlemlerinde model tanımlamak yerine aşağıdaki yapılar ilede view'a veri bind edilebilir...

            // ViewData ve ViewBag oluşturulduktan sonra o anki requestte okunur, sonraki requestte okunmaz..

            ViewData["data1"] = myClass.uid;
            ViewBag.data2 = myClass2.uid;

            return View();
        }
    }
}