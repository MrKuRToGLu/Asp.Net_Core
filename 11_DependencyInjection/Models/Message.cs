namespace _11_DependencyInjection.Models
{

    // interface'den instance alınmaz ancak miras alan sınıflarının instancelarını tutabilirler...
    // Inheritance (miras alma) => MessageTR ve MessageEn sınıflarının interfaceden türemesi
    // Abstraction (soyutlama) => interface tanımı
    // Polymorphism(Çok biçimlilik) => Mesaj metodunun MessageTR ve MessageENg'de farklı içeriklerinin olması

    public interface IMessage {
        public string Mesaj();
    }
    public class MessageTr : IMessage
    {
        public string Mesaj()
        {
            return "Merhaba Dünya...";
        }
        //public string MesajEng()
        //{
        //    return "Hello World";
        //}
    }
    public class MessageEng : IMessage
    {
        public string Mesaj()
        {
            return "Hello World";
        }
    }
}