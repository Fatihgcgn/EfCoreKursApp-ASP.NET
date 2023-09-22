using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EfCoreKursApp.Data;

namespace EfCoreKursApp.Models
{
    public class KursViewModel
    {
        public int KursId { get; set; }
        [Required(ErrorMessage = "Kurs adı zorunludur")]
        [StringLength(50)]
        [DisplayName("Kurs Başlığı")]
        public string? Baslik { get; set; }

        public int OgretmenId { get; set; }
        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();
    }
}