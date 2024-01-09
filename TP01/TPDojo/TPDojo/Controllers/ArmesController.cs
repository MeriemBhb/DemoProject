using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BO;
using TPDojo.Data;

namespace TPDojo.Controllers
{
    public class ArmesController : Controller
    {
        private readonly TPDojoContext _context;

        public ArmesController(TPDojoContext context)
        {
            _context = context;
        }

        // GET: Armes
        public async Task<IActionResult> Index()
        {
              return _context.Armes != null ? 
                          View(await _context.Armes.ToListAsync()) :
                          Problem("Entity set 'TPDojoContext.Armes'  is null.");
        }

        // GET: Armes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Armes == null)
            {
                return NotFound();
            }

            var armes = await _context.Armes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (armes == null)
            {
                return NotFound();
            }

            return View(armes);
        }

        // GET: Armes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Armes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Degats")] Armes armes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(armes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(armes);
        }

        // GET: Armes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Armes == null)
            {
                return NotFound();
            }

            var armes = await _context.Armes.FindAsync(id);
            if (armes == null)
            {
                return NotFound();
            }
            return View(armes);
        }

        // POST: Armes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Degats")] Armes armes)
        {
            if (id != armes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(armes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArmesExists(armes.Id))
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
            return View(armes);
        }

        // GET: Armes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Armes == null)
            {
                return NotFound();
            }

            var armes = await _context.Armes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (armes == null)
            {
                return NotFound();
            }

            return View(armes);
        }

        // POST: Armes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Armes == null)
            {
                return Problem("Entity set 'TPDojoContext.Armes'  is null.");
            }
            var armes = await _context.Armes.FindAsync(id);
            if (armes != null)
            {
                _context.Armes.Remove(armes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArmesExists(int id)
        {
          return (_context.Armes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
