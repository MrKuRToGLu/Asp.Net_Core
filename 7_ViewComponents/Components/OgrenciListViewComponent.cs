//using BizimProjeninModel;
using Microsoft.AspNetCore.Mvc;
using System.Xml;

namespace _7_ViewComponents.Components
{
    public class OgrenciListViewComponent : ViewComponent
    {
        Microsoft.AspNetCore.Hosting.IHostingEnvironment _env;

        public OgrenciListViewComponent(Microsoft.AspNetCore.Hosting.IHostingEnvironment env
            )
        {
            _env = env;
        }

        public IViewComponentResult Invoke(Cinsiyet _Cinsiyet)
        {
            string wwwPath = _env.WebRootPath; // wwwroot folder'ina eriştik...
            //string xmlFilePath = wwwPath + "/" + "Ogrenciler.xml";
            string xmlFilePath1 = Path.Combine(wwwPath, "Ogrenciler.xml");
            // XmlDocument => xml verileri üzerinde işlem yapmamızı sağlan dosyadır (ekleme, silme, güncelleme, arama, listeleme vb.)..
            XmlDocument xdoc = new XmlDocument();
            //xdoc.LoadXml("<Ogrenci><Adi>Test</Adi></Ogrenci>");
            xdoc.Load(xmlFilePath1); // belirtilen path'teki dosyası XmlDocument tipindeki nesne üzerinden okumamızı sağlar...
            #region "xpath örnekleri"
            //xdoc.SelectNodes("Ogrenciler/Ogrenci");
            //xdoc.DocumentElement.SelectNodes("Ogrenci");
            // xdoc.DocumentElement.SelectNodes("Ogrenci/Adi"); // Adi elementlerini liste olarak döner..
            //XmlNodeList xNodeList = xdoc.DocumentElement.SelectNodes("Ogrenci"); // Ogrenci Nodelerini listele olarak dön...
            #endregion 
            // xpath ile search
            string searchVal = Enum.GetName<Cinsiyet>(_Cinsiyet);
            XmlNodeList xNodeList = xdoc.DocumentElement.SelectNodes($"Ogrenci[Cinsiyet='{searchVal}']");
            List<Ogrenci> ogrencis = new List<Ogrenci>();
            foreach (XmlNode xnode in xNodeList)
            {
                Ogrenci ogr = new Ogrenci();
                ogr.Adi = xnode["Adi"].InnerText;
                ogr.SoyAdi = xnode["SoyAdi"].InnerText;
                ogr.Cinsiyet = Enum.Parse<Cinsiyet>(xnode["Cinsiyet"].InnerText);
                ogrencis.Add(ogr);
            }
            return View(ogrencis);
        }
    }
}
