using _11_DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace _11_DependencyInjection.Controllers
{
    // HomeController sınıfının Message sınıfına sıkı sıkıya bağımlı olmasının dezavantajları;

    // 1) Message(düşük seviyeli) sınıfı içerisinde yapılacak bir değişikliğin HomeController(yüksek seviyeli) sınıfnı etkilemesi
    // 2) T anında HomeController sınıfında farklı message nesnesinin kullanılmasının yine HomeController sınıfını etkilemesi...

    public class HomeController : Controller
    {
        // MessageTr message = new MessageTr();
        //MessageEng mE = new MessageEng();
        IMessage message; // IMessagge kullanarak bağımlılıkları tersine çeviriyoruz..
        public HomeController(IMessage _message) // runtime'da instance resolve edilir....
        {
            message = _message;
        }
        public IActionResult Index()
        {
            //Message message = new Message();
            return Json(message.Mesaj());
        }
    }
    // HomeController sınıfının message üyesinei IMessage türüne çevirerek HomeController sınıfını MessageTr ve MessageEng sınıflarından soyutlamış olduk...
}