using Microsoft.AspNetCore.Mvc;

namespace _7_ViewComponents.Components
{
    // ViewComponent => viewlardan request yapılıp, geriye view (partial) dönen sınıflardır.. bu sınıfın içerine bir adet Invoke isimli bir metot tanımlanır...
    public class MyComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View(); // Geriye Default.cshtml isimli dosyayı döner...
        }

    }
}
