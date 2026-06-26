using System.ComponentModel.DataAnnotations;

namespace KargoTakipSistemi1.Models
{
    public class Kullanici
    {
        public int Id { get; set; }

        [Required]
        public string AdSoyad { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Sifre { get; set; } = string.Empty;

        [Required]
        public string Rol { get; set; } = string.Empty;
    }
}