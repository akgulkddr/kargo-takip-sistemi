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
    public class DurumKayitlariController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DurumKayitlariController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DurumKayitlari
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DurumKayitlari
                .Include(d => d.Kargo)
                .OrderByDescending(d => d.Tarih)
                .ThenByDescending(d => d.Id);

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DurumKayitlari/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var durumKaydi = await _context.DurumKayitlari
                .Include(d => d.Kargo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (durumKaydi == null)
            {
                return NotFound();
            }

            return View(durumKaydi);
        }

        // GET: DurumKayitlari/Create
        public IActionResult Create()
        {
            var kargolar = _context.Kargolar
                .Select(k => new
                {
                    k.Id,
                    DisplayText = k.TakipNo + " - " + k.KargoTuru
                })
                .ToList();

            ViewData["KargoId"] = new SelectList(kargolar, "Id", "DisplayText");

            return View();
        }

        // POST: DurumKayitlari/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Durum,Tarih,KargoId")] DurumKaydi durumKaydi)
        {
            if (ModelState.IsValid)
            {
                durumKaydi.Tarih = DateTime.Now;
                _context.Add(durumKaydi);
                await _context.SaveChangesAsync();

                TempData["BasariMesaji"] = "Durum kaydý baþarýyla eklendi.";

                return RedirectToAction(nameof(Index));
            }
            var kargolar = _context.Kargolar
    .Select(k => new
    {
        k.Id,
        DisplayText = k.TakipNo + " - " + k.KargoTuru
    })
    .ToList();

            ViewData["KargoId"] = new SelectList(kargolar, "Id", "DisplayText", durumKaydi.KargoId);

            return View(durumKaydi);
        }

        // GET: DurumKayitlari/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var durumKaydi = await _context.DurumKayitlari.FindAsync(id);
            if (durumKaydi == null)
            {
                return NotFound();
            }
            var kargolar = _context.Kargolar
     .Select(k => new
     {
         k.Id,
         DisplayText = k.TakipNo + " - " + k.KargoTuru
     })
     .ToList();

            ViewData["KargoId"] = new SelectList(kargolar, "Id", "DisplayText", durumKaydi.KargoId);
            return View(durumKaydi);
        }

        // POST: DurumKayitlari/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Durum,Tarih,KargoId")] DurumKaydi durumKaydi)
        {
            if (id != durumKaydi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    durumKaydi.Tarih = DateTime.Now;
                    

                    _context.Update(durumKaydi);
                    await _context.SaveChangesAsync();

                    TempData["BasariMesaji"] = "Durum kaydý baþarýyla güncellendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DurumKaydiExists(durumKaydi.Id))
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
            var kargolar = _context.Kargolar
     .Select(k => new
     {
         k.Id,
         DisplayText = k.TakipNo + " - " + k.KargoTuru
     })
     .ToList();

            ViewData["KargoId"] = new SelectList(kargolar, "Id", "DisplayText", durumKaydi.KargoId);

            return View(durumKaydi);
        }

        // GET: DurumKayitlari/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var durumKaydi = await _context.DurumKayitlari
                .Include(d => d.Kargo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (durumKaydi == null)
            {
                return NotFound();
            }

            return View(durumKaydi);
        }

        // POST: DurumKayitlari/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var durumKaydi = await _context.DurumKayitlari.FindAsync(id);
            if (durumKaydi != null)
            {
                _context.DurumKayitlari.Remove(durumKaydi);
            }

            await _context.SaveChangesAsync();

            TempData["BasariMesaji"] = "Durum kaydý baþarýyla silindi.";

            return RedirectToAction(nameof(Index));
        }

        private bool DurumKaydiExists(int id)
        {
            return _context.DurumKayitlari.Any(e => e.Id == id);
        }
    }
}
