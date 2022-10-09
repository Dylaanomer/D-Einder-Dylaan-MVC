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
    public class ReservatiesController : Controller
    {
        private readonly DataDbContext _context;

        public ReservatiesController(DataDbContext context)
        {
            _context = context;
        }

        // GET: Reservaties
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reservatie.ToListAsync());
        }

        // GET: Reservaties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservatie = await _context.Reservatie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservatie == null)
            {
                return NotFound();
            }

            return View(reservatie);
        }

        // GET: Reservaties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reservaties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,User,Tijd,Tafel,MenuKeuzes")] Reservatie reservatie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservatie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reservatie);
        }

        // GET: Reservaties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservatie = await _context.Reservatie.FindAsync(id);
            if (reservatie == null)
            {
                return NotFound();
            }
            return View(reservatie);
        }

        // POST: Reservaties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,User,Tijd,Tafel,MenuKeuzes")] Reservatie reservatie)
        {
            if (id != reservatie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservatie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservatieExists(reservatie.Id))
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
            return View(reservatie);
        }

        // GET: Reservaties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservatie = await _context.Reservatie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservatie == null)
            {
                return NotFound();
            }

            return View(reservatie);
        }

        // POST: Reservaties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservatie = await _context.Reservatie.FindAsync(id);
            _context.Reservatie.Remove(reservatie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservatieExists(int id)
        {
            return _context.Reservatie.Any(e => e.Id == id);
        }
    }
}
