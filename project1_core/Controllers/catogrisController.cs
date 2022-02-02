using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project1_core.Models;

namespace project1_core.Controllers
{
    public class catogrisController : Controller
    {
        private readonly newscontixit _context;

        public catogrisController(newscontixit context)
        {
            _context = context;
        }

        // GET: catogris
        public async Task<IActionResult> Index()
        {
            return View(await _context.catogris.ToListAsync());
        }

        // GET: catogris/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catogri = await _context.catogris
                .FirstOrDefaultAsync(m => m.id == id);
            if (catogri == null)
            {
                return NotFound();
            }

            return View(catogri);
        }

        // GET: catogris/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: catogris/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,description")] catogri catogri)
        {
            if (ModelState.IsValid)
            {
                _context.Add(catogri);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catogri);
        }

        // GET: catogris/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catogri = await _context.catogris.FindAsync(id);
            if (catogri == null)
            {
                return NotFound();
            }
            return View(catogri);
        }

        // POST: catogris/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,description")] catogri catogri)
        {
            if (id != catogri.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catogri);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!catogriExists(catogri.id))
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
            return View(catogri);
        }

        // GET: catogris/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catogri = await _context.catogris
                .FirstOrDefaultAsync(m => m.id == id);
            if (catogri == null)
            {
                return NotFound();
            }

            return View(catogri);
        }

        // POST: catogris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var catogri = await _context.catogris.FindAsync(id);
            _context.catogris.Remove(catogri);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool catogriExists(int id)
        {
            return _context.catogris.Any(e => e.id == id);
        }
    }
}
