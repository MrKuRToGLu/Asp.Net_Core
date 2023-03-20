namespace _9_ViewModel.Models
{
    public class OgrenciRepository
    {
        List<Ogrenci> ogrencis = new List<Ogrenci>();
        public OgrenciRepository()
        {
            ogrencis.Add(new Ogrenci { OgrenciID = 1, Adi = "Havva", SoyAdi = "Yiğit" });
            ogrencis.Add(new Ogrenci { OgrenciID = 2, Adi = "Burak", SoyAdi = "Öz" });
            ogrencis.Add(new Ogrenci { OgrenciID = 3, Adi = "Ayşenur", SoyAdi = "Aydığdu" });
            ogrencis.Add(new Ogrenci { OgrenciID = 4, Adi = "Ebubekir", SoyAdi = "Seyyarer" });
        }

        public List<Ogrenci> GetList()
        {
            return ogrencis;
        }
        public Ogrenci GetOgrenci(int Id)
        {
            return ogrencis.FirstOrDefault(c => c.OgrenciID == Id);
        }
    }
}