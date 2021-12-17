#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhanHuyLoc216.Models;

namespace PhanHuyLoc216.Controllers
{
    public class PHL0216Controller : Controller
    {
        private readonly MvcMovieContext _context;

        public PHL0216Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: PHL0216
        public async Task<IActionResult> Index()
        {
            return View(await _context.PHL0216.ToListAsync());
        }

        // GET: PHL0216/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var PHL0216 = await _context.PHL0216
                .FirstOrDefaultAsync(m => m.DTAID == id);
            if (PHL0216 == null)
            {
                return NotFound();
            }

            return View(PHL0216);
        }

        // GET: PHL0216/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PHL0216/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DTAID,DTAName,DTAGender")] PHL0216 PHL0216)
        {
            if (ModelState.IsValid)
            {
                _context.Add(PHL0216);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(PHL0216);
        }

        // GET: PHL0216/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var PHL0216 = await _context.PHL0216.FindAsync(id);
            if (PHL0216 == null)
            {
                return NotFound();
            }
            return View(PHL0216);
        }

        // POST: PHL0216/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DTAID,DTAName,DTAGender")] PHL0216 PHL0216)
        {
            if (id != PHL0216.DTAID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(PHL0216);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PHL0216Exists(PHL0216.DTAID))
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
            return View(PHL0216);
        }

        // GET: PHL0216/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var PHL0216 = await _context.PHL0216
                .FirstOrDefaultAsync(m => m.DTAID == id);
            if (PHL0216 == null)
            {
                return NotFound();
            }

            return View(PHL0216);
        }

        // POST: PHL0216/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var PHL0216 = await _context.PHL0216.FindAsync(id);
            _context.PHL0216.Remove(PHL0216);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PHL0216Exists(string id)
        {
            return _context.PHL0216.Any(e => e.DTAID == id);
        }
    }
}