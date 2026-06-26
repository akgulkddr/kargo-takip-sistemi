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
    public class PersonellerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonellerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Personeller
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Personeller
     .Include(p => p.Sube)
     .OrderByDescending(p => p.Id);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Personeller/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personel = await _context.Personeller
                .Include(p => p.Sube)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personel == null)
            {
                return NotFound();
            }

            return View(personel);
        }

        // GET: Personeller/Create
        public IActionResult Create()
        {
            ViewData["SubeId"] = new SelectList(_context.Subeler, "Id", "Adres");
            return View();
        }

        // POST: Personeller/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AdSoyad,Gorev,Telefon,SubeId")] Personel personel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personel);
                await _context.SaveChangesAsync();

                TempData["BasariMesaji"] = "Personel kaydý baþarýyla eklendi.";

                return RedirectToAction(nameof(Index));
            }
            ViewData["SubeId"] = new SelectList(_context.Subeler, "Id", "Adres", personel.SubeId);
            return View(personel);
        }

        // GET: Personeller/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personel = await _context.Personeller.FindAsync(id);
            if (personel == null)
            {
                return NotFound();
            }
            ViewData["SubeId"] = new SelectList(_context.Subeler, "Id", "Adres", personel.SubeId);
            return View(personel);
        }

        // POST: Personeller/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AdSoyad,Gorev,Telefon,SubeId")] Personel personel)
        {
            if (id != personel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personel);
                    await _context.SaveChangesAsync();

                    TempData["BasariMesaji"] = "Personel kaydý baþarýyla güncellendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonelExists(personel.Id))
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
            ViewData["SubeId"] = new SelectList(_context.Subeler, "Id", "Adres", personel.SubeId);
            return View(personel);
        }

        // GET: Personeller/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personel = await _context.Personeller
                .Include(p => p.Sube)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personel == null)
            {
                return NotFound();
            }

            return View(personel);
        }

        // POST: Personeller/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personel = await _context.Personeller.FindAsync(id);
            if (personel != null)
            {
                _context.Personeller.Remove(personel);
            }
            await _context.SaveChangesAsync();

            TempData["BasariMesaji"] = "Personel kaydý baþarýyla silindi.";

            return RedirectToAction(nameof(Index));
        }

        private bool PersonelExists(int id)
        {
            return _context.Personeller.Any(e => e.Id == id);
        }
    }
}
