using System.ComponentModel.DataAnnotations;

namespace KargoTakipSistemi1.Models
{
    public class DurumKaydi
    {

        public int Id { get; set; }



        [Required(ErrorMessage = "Durum bilgisi zorunludur.")]
        [StringLength(100)]
        public required string Durum { get; set; }

        [Required(ErrorMessage = "Tarih zorunludur.")]
        public DateTime Tarih { get; set; }



        [Required(ErrorMessage = "Kargo seçimi zorunludur.")]
        public int KargoId { get; set; }

        public Kargo? Kargo { get; set; }
    }
}
