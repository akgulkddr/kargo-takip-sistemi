using KargoTakipSistemi1.Data;
using KargoTakipSistemi1.Models;
using Microsoft.AspNetCore.Mvc;

namespace KargoTakipSistemi1.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Login(string email, string sifre)
        {
            var kullanici = _context.Kullanicilar
                .FirstOrDefault(x =>
                    x.Email == email &&
                    x.Sifre == sifre);

            if (kullanici == null)
            {
                TempData["LoginHata"] =
                    "E-posta veya şifre yanlış.";

                return RedirectToAction(
                    "Index",
                    "Home");
            }

            HttpContext.Session.SetString(
                "KullaniciAd",
                kullanici.AdSoyad);

            HttpContext.Session.SetString(
                "KullaniciRol",
                kullanici.Rol);

            if (kullanici.Rol == "Yonetici")
            {
                return RedirectToAction(
                    "Index",
                    "Home");
            }

            return RedirectToAction(
                "Takip",
                "Kargolar");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction(
                "Index",
                "Home");
        }
    }
}