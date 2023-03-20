using System.ComponentModel.DataAnnotations;

namespace _9_ViewModel.Models
{
    public class Ogrenci
    {
        [Display(Name = "Öğrenci No")]
        [ScaffoldColumn(false)] // Template içerisinde bu alan oluştulmaz..
        public int OgrenciID { get; set; }

        [Display(Name = "Adı")]
        public string Adi { get; set; }

        [Display(Name = "SoyAdı")]
        public string SoyAdi { get; set; }
    }
}