using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using D_Einder_Dylaan_MVC.Data;
using D_Einder_Dylaan_MVC.Models;

namespace D_Einder_Dylaan_MVC.Controllers
{
    public class BestellingensController : Controller
    {
        private readonly DataDbContext _context;

        public BestellingensController(DataDbContext context)
        {
            _context = context;
        }

        // GET: Bestellingens
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bestellingen.ToListAsync());
        }

        // GET: Bestellingens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bestellingen = await _context.Bestellingen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bestellingen == null)
            {
                return NotFound();
            }

            return View(bestellingen);
        }

        // GET: Bestellingens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bestellingens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Bestelling,Tijd,Tafel")] Bestellingen bestellingen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bestellingen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bestellingen);
        }

        // GET: Bestellingens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bestellingen = await _context.Bestellingen.FindAsync(id);
            if (bestellingen == null)
            {
                return NotFound();
            }
            return View(bestellingen);
        }

        // POST: Bestellingens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Bestelling,Tijd,Tafel")] Bestellingen bestellingen)
        {
            if (id != bestellingen.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bestellingen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BestellingenExists(bestellingen.Id))
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
            return View(bestellingen);
        }

        // GET: Bestellingens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bestellingen = await _context.Bestellingen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bestellingen == null)
            {
                return NotFound();
            }

            return View(bestellingen);
        }

        // POST: Bestellingens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bestellingen = await _context.Bestellingen.FindAsync(id);
            _context.Bestellingen.Remove(bestellingen);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BestellingenExists(int id)
        {
            return _context.Bestellingen.Any(e => e.Id == id);
        }
    }
}
