namespace _11_DependencyInjection.Models
{

    public interface IOgrenci
    {
        List<string> List();
    }

    public class Tembeller : IOgrenci
    {
        public List<string> List()
        {
            List<string> ogrencis = new List<string>();
            ogrencis.Add("Umut");
            ogrencis.Add("Ebubekir");
            ogrencis.Add("Ramazan");
            ogrencis.Add("Burak");
            ogrencis.Add("Ekrem");
            ogrencis.Add("Mertcan");
            ogrencis.Add("İsmail");
            return ogrencis;
        }
    }

    public class Caliskanlar : IOgrenci
    {
        public List<string> List()
        {
            List<string> ogrencis = new List<string>();
            ogrencis.Add("Hava");
            ogrencis.Add("Merve");
            ogrencis.Add("Cemre");

            return ogrencis;
        }
    }
}