using System.ComponentModel.DataAnnotations;

namespace KargoTakipSistemi1.Models
{
    public class Musteri
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad soyad zorunludur.")]
        [StringLength(100)]
        public string AdSoyad { get; set; }

        [Required(ErrorMessage = "Telefon numarası zorunludur.")]
        [StringLength(20)]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "E-mail zorunludur.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şehir zorunludur.")]
        [StringLength(250)]
        public string Adres { get; set; }

        public ICollection<Kargo>? GonderilenKargolar { get; set; }
        public ICollection<Kargo>? AlinanKargolar { get; set; }
    }
}
