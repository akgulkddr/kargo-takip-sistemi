using System.ComponentModel.DataAnnotations;

namespace KargoTakipSistemi1.Models
{
    public class Kargo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Takip numarası zorunludur.")]
        [StringLength(20)]
        public required string TakipNo { get; set; }

        [Required(ErrorMessage = "Kargo türü zorunludur.")]
        [StringLength(50)]
        public required string KargoTuru { get; set; }

        [Required(ErrorMessage = "Ağırlık bilgisi zorunludur.")]
        public double Agirlik { get; set; }

        [Required(ErrorMessage = "Gönderim tarihi zorunludur.")]
        public DateTime GonderimTarihi { get; set; }

        [Required(ErrorMessage = "Gönderici zorunludur.")]
        public int GondericiId { get; set; }

        [Required(ErrorMessage = "Alıcı zorunludur.")]
        public int AliciId { get; set; }

        [Required(ErrorMessage = "Çıkış şubesi zorunludur.")]
        public int CikisSubeId { get; set; }

        [Required(ErrorMessage = "Varış şubesi zorunludur.")]
        public int VarisSubeId { get; set; }

        public Musteri? Gonderici { get; set; }
        public Musteri? Alici { get; set; }

        public Sube? CikisSube { get; set; }
        public Sube? VarisSube { get; set; }

        public ICollection<DurumKaydi>? DurumKayitlari { get; set; }
    }
}