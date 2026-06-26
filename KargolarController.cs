using KargoTakipSistemi1.Data;
using KargoTakipSistemi1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KargoTakipSistemi1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var dashboardKartlari = new List<DashboardKart>
            {
                new DashboardKart
                {
                    Baslik = "Toplam Kargo",
                    Sayi = _context.Kargolar.Count(),
                    Aciklama = "Sistemde kayıtlı kargo",
                    Ikon = "📦",
                    CssClass = "card-blue"
                },

                new DashboardKart
                {
                    Baslik = "Şube Sayısı",
                    Sayi = _context.Subeler.Count(),
                    Aciklama = "Aktif şube",
                    Ikon = "🏢",
                    CssClass = "card-green"
                },

                new DashboardKart
                {
                    Baslik = "Müşteri Sayısı",
                    Sayi = _context.Musteriler.Count(),
                    Aciklama = "Kayıtlı müşteri",
                    Ikon = "👥",
                    CssClass = "card-orange"
                },

                new DashboardKart
                {
                    Baslik = "Personel Sayısı",
                    Sayi = _context.Personeller.Count(),
                    Aciklama = "Kayıtlı personel",
                    Ikon = "👤",
                    CssClass = "card-purple"
                }
            };

            return View(dashboardKartlari);
        }

        public IActionResult Ara(string arama)
        {
            if (string.IsNullOrWhiteSpace(arama))
            {
                return RedirectToAction("Index");
            }

            arama = arama.ToLower();

            var kargolar = _context.Kargolar
                .Include(k => k.Gonderici)
                .Include(k => k.Alici)
                .Include(k => k.CikisSube)
                .Include(k => k.VarisSube)
                .Where(k =>
                    k.TakipNo.ToLower().Contains(arama) ||
                    k.KargoTuru.ToLower().Contains(arama) ||

                    (k.Gonderici != null &&
                     k.Gonderici.AdSoyad.ToLower().Contains(arama)) ||

                    (k.Alici != null &&
                     k.Alici.AdSoyad.ToLower().Contains(arama)) ||

                    (k.CikisSube != null &&
                     k.CikisSube.SubeAdi.ToLower().Contains(arama)) ||

                    (k.VarisSube != null &&
                     k.VarisSube.SubeAdi.ToLower().Contains(arama)))
                .ToList();

            var musteriler = _context.Musteriler
                .Where(m =>
                    m.AdSoyad.ToLower().Contains(arama) ||
                    m.Email.ToLower().Contains(arama) ||
                    m.Telefon.ToLower().Contains(arama) ||
                    m.Adres.ToLower().Contains(arama))
                .ToList();

            var personeller = _context.Personeller
                .Include(p => p.Sube)
                .Where(p =>
                    p.AdSoyad.ToLower().Contains(arama) ||
                    p.Gorev.ToLower().Contains(arama) ||
                    p.Telefon.ToLower().Contains(arama) ||

                    (p.Sube != null &&
                     p.Sube.SubeAdi.ToLower().Contains(arama)))
                .ToList();

            var subeler = _context.Subeler
                .Where(s =>
                    s.SubeAdi.ToLower().Contains(arama) ||
                    s.Sehir.ToLower().Contains(arama) ||
                    s.Ilce.ToLower().Contains(arama) ||
                    s.Adres.ToLower().Contains(arama) ||
                    s.Telefon.ToLower().Contains(arama))
                .ToList();

            ViewBag.Arama = arama;
            ViewBag.Kargolar = kargolar;
            ViewBag.Musteriler = musteriler;
            ViewBag.Personeller = personeller;
            ViewBag.Subeler = subeler;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}