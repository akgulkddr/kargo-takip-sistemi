using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KargoTakipSistemi1.Data;
using KargoTakipSistemi1.Models;

namespace KargoTakipSistemi1.Controllers
{
    public class KargolarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KargolarController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Kargolar
        public async Task<IActionResult> Index()
        {
            var kargolar = _context.Kargolar
                .Include(k => k.Gonderici)
                .Include(k => k.Alici)
                .Include(k => k.CikisSube)
                .Include(k => k.VarisSube);

            return View(await kargolar
    .OrderByDescending(x => x.Id)
    .ToListAsync());
        }

        public async Task<IActionResult> Takip(string takipNo)
        {
            var model = new KargoTakipViewModel();

            if (string.IsNullOrEmpty(takipNo))
            {
                model.Mesaj = "Lütfen takip numarasý giriniz.";
                return View(model);
            }

            var kargo = await _context.Kargolar
                .Include(k => k.Gonderici)
                .Include(k => k.Alici)
                .Include(k => k.CikisSube)
                .Include(k => k.VarisSube)
                .Include(k => k.DurumKayitlari)
                .FirstOrDefaultAsync(k => k.TakipNo == takipNo);

            if (kargo == null)
            {
                model.Mesaj = "Bu takip numarasýna ait kargo bulunamadý.";
                return View(model);
            }

            model.Kargo = kargo;

            return View(model);
        }

        // GET: Kargolar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kargo = await _context.Kargolar
                .Include(k => k.Alici)
                .Include(k => k.CikisSube)
                .Include(k => k.Gonderici)
                .Include(k => k.VarisSube)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kargo == null)
            {
                return NotFound();
            }

            return View(kargo);
        }

        // GET: Kargolar/Create
        public IActionResult Create()
        {
            ViewData["AliciId"] = new SelectList(_context.Musteriler, "Id", "AdSoyad");
            ViewData["GondericiId"] = new SelectList(_context.Musteriler, "Id", "AdSoyad");
            var subeler = _context.Subeler
    .Select(s => new
    {
        s.Id,
        DisplayText = s.Sehir + " / " + s.Ilce + " - " + s.SubeAdi
    })
    .ToList();

            ViewData["CikisSubeId"] = new SelectList(subeler, "Id", "DisplayText");
            ViewData["VarisSubeId"] = new SelectList(subeler, "Id", "DisplayText");
            return View();
        }

        // POST: Kargolar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TakipNo,KargoTuru,Agirlik,GonderimTarihi,GondericiId,AliciId,CikisSubeId,VarisSubeId")] Kargo kargo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kargo);
                await _context.SaveChangesAsync();

                TempData["BasariMesaji"] = "Kargo kaydý baþarýyla eklendi.";

                return RedirectToAction(nameof(Index));
            }
            ViewData["AliciId"] = new SelectList(_context.Musteriler, "Id", "AdSoyad", kargo.AliciId);
            ViewData["GondericiId"] = new SelectList(_context.Musteriler, "Id", "AdSoyad", kargo.GondericiId);
            var subeler = _context.Subeler
    .Select(s => new
    {
        s.Id,
        DisplayText = s.Sehir + " / " + s.Ilce + " - " + s.SubeAdi
    })
    .ToList();

            ViewData["CikisSubeId"] = new SelectList(subeler, "Id", "DisplayText", kargo.CikisSubeId);
            ViewData["VarisSubeId"] = new SelectList(subeler, "Id", "DisplayText", kargo.VarisSubeId);
            return View(kargo);
        }

        // GET: Kargolar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kargo = await _context.Kargolar.FindAsync(id);
            if (kargo == null)
            {
                return NotFound();
            }
            ViewData["AliciId"] = new SelectList(_context.Musteriler, "Id", "AdSoyad", kargo.AliciId);
            ViewData["GondericiId"] = new SelectList(_context.Musteriler, "Id", "AdSoyad", kargo.GondericiId);
            var subeler = _context.Subeler
    .Select(s => new
    {
        s.Id,
        DisplayText = s.Sehir + " / " + s.Ilce + " - " + s.SubeAdi
    })
    .ToList();

            ViewData["CikisSubeId"] = new SelectList(subeler, "Id", "DisplayText", kargo.CikisSubeId);
            ViewData["VarisSubeId"] = new SelectList(subeler, "Id", "DisplayText", kargo.VarisSubeId);
            return View(kargo);
        }

        // POST: Kargolar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TakipNo,KargoTuru,Agirlik,GonderimTarihi,GondericiId,AliciId,CikisSubeId,VarisSubeId")] Kargo kargo)
        {
            if (id != kargo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kargo);
                    await _context.SaveChangesAsync();

                    TempData["BasariMesaji"] = "Kargo kaydý baþarýyla güncellendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KargoExists(kargo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AliciId"] = new SelectList(_context.Musteriler, "Id", "AdSoyad", kargo.AliciId);
            ViewData["GondericiId"] = new SelectList(_context.Musteriler, "Id", "AdSoyad", kargo.GondericiId);
            var subeler = _context.Subeler
    .Select(s => new
    {
        s.Id,
        DisplayText = s.Sehir + " / " + s.Ilce + " - " + s.SubeAdi
    })
    .ToList();

            ViewData["CikisSubeId"] = new SelectList(subeler, "Id", "DisplayText", kargo.CikisSubeId);
            ViewData["VarisSubeId"] = new SelectList(subeler, "Id", "DisplayText", kargo.VarisSubeId);
            return View(kargo);
        }

        // GET: Kargolar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kargo = await _context.Kargolar
                .Include(k => k.Alici)
                .Include(k => k.CikisSube)
                .Include(k => k.Gonderici)
                .Include(k => k.VarisSube)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kargo == null)
            {
                return NotFound();
            }

            return View(kargo);
        }

        // POST: Kargolar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kargo = await _context.Kargolar.FindAsync(id);
            if (kargo != null)
            {
                _context.Kargolar.Remove(kargo);
            }

            await _context.SaveChangesAsync();

            TempData["BasariMesaji"] = "Kargo kaydý baþarýyla silindi.";

            return RedirectToAction(nameof(Index));
        }

        private bool KargoExists(int id)
        {
            return _context.Kargolar.Any(e => e.Id == id);
        }
    }
}
