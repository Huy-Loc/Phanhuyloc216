using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DinhTheAnh082.Models;

namespace DinhTheAnh082.Controllers
{
    public class UniversityPHL216Controller : Controller
    {
        StringProcess strpro = new StringProcess();
        private readonly MvcMovieContext _context;

        public UniversityPHL216Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: UniversityPHL216
        public async Task<IActionResult> Index()
        {
            return View(await _context.UniversityPHL216.ToListAsync());
        }

        // GET: UniversityPHL216/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityPHL216 = await _context.UniversityPHL216
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityPHL216 == null)
            {
                return NotFound();
            }

            return View(universityPHL216);
        }

        // GET: UniversityPHL216/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityPHL216/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityId,UniversityName")] UniversityPHL216 universityPHL216)
        {
            if (ModelState.IsValid)
            {
                universityPHL216.UniversityName = strpro.LowerToUpper(universityPHL216.UniversityName);
                _context.Add(universityPHL216);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityPHL216);
        }

        // GET: UniversityPHL216/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityPHL216 = await _context.UniversityPHL216.FindAsync(id);
            if (universityPHL216 == null)
            {
                return NotFound();
            }
            return View(universityPHL216);
        }

        // POST: UniversityPHL216/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityId,UniversityName")] UniversityPHL216 universityPHL216)
        {
            if (id != universityPHL216.UniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    universityPHL216.UniversityName = strpro.LowerToUpper(universityPHL216.UniversityName);
                    _context.Update(universityPHL216);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityPHL216Exists(universityPHL216.UniversityId))
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
            return View(universityPHL216);
        }

        // GET: UniversityPHL216/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityPHL216 = await _context.UniversityPHL216
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityPHL216 == null)
            {
                return NotFound();
            }

            return View(universityPHL216);
        }

        // POST: UniversityPHL216/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var universityPHL216 = await _context.UniversityPHL216.FindAsync(id);
            _context.UniversityPHL216.Remove(universityPHL216);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityPHL216Exists(string id)
        {
            return _context.UniversityPHL216.Any(e => e.UniversityId == id);
        }
    }
}