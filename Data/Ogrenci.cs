using System.ComponentModel.DataAnnotations;

namespace EfCoreKursApp.Data
{
    public class Ogrenci
    {
        [Key]
        public int OgrenciId { get; set; }
        public string? OgrenciAd { get; set; }
        public string? OgrenciSoyAd { get; set; }
        public string? AdSoyad
        {
            get
            {
                return this.OgrenciAd + " " + this.OgrenciSoyAd;
            }
        }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }

    }
}