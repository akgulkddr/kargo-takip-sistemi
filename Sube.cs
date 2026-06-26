using System.ComponentModel.DataAnnotations;

namespace KargoTakipSistemi1.Models
{
    public class Personel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad soyad zorunludur.")]
        [StringLength(100)]
        public required string AdSoyad { get; set; }

        [Required(ErrorMessage = "Görev zorunludur.")]
        [StringLength(50)]
        public required string Gorev { get; set; }

        [Required(ErrorMessage = "Telefon zorunludur.")]
        [StringLength(20)]
        public required string Telefon { get; set; }

        [Required(ErrorMessage = "Şube zorunludur.")]
        public int SubeId { get; set; }
       

        public Sube? Sube { get; set; }

    }
}
