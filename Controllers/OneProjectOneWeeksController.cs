using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WADNghi13A.Models;

namespace WADNghi13A.Controllers
{
    public class OneProjectOneWeeksController : Controller
    {
        private readonly WADNghi13AContext _context;

        public OneProjectOneWeeksController(WADNghi13AContext context)
        {
            _context = context;
        }

        // GET: OneProjectOneWeeks
        public async Task<IActionResult> Index()
        {
            return View(await _context.OneProjectOneWeek.ToListAsync());
        }

        // GET: OneProjectOneWeeks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oneProjectOneWeek = await _context.OneProjectOneWeek
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oneProjectOneWeek == null)
            {
                return NotFound();
            }

            return View(oneProjectOneWeek);
        }

        // GET: OneProjectOneWeeks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OneProjectOneWeeks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Employee,Project,ArriveDt,DepartureDt,OneWeek")] OneProjectOneWeek oneProjectOneWeek)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oneProjectOneWeek);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(oneProjectOneWeek);
        }

        // GET: OneProjectOneWeeks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oneProjectOneWeek = await _context.OneProjectOneWeek.FindAsync(id);
            if (oneProjectOneWeek == null)
            {
                return NotFound();
            }
            return View(oneProjectOneWeek);
        }

        // POST: OneProjectOneWeeks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Employee,Project,ArriveDt,DepartureDt,OneWeek")] OneProjectOneWeek oneProjectOneWeek)
        {
            if (id != oneProjectOneWeek.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oneProjectOneWeek);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OneProjectOneWeekExists(oneProjectOneWeek.Id))
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
            return View(oneProjectOneWeek);
        }

        // GET: OneProjectOneWeeks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oneProjectOneWeek = await _context.OneProjectOneWeek
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oneProjectOneWeek == null)
            {
                return NotFound();
            }

            return View(oneProjectOneWeek);
        }

        // POST: OneProjectOneWeeks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oneProjectOneWeek = await _context.OneProjectOneWeek.FindAsync(id);
            _context.OneProjectOneWeek.Remove(oneProjectOneWeek);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OneProjectOneWeekExists(int id)
        {
            return _context.OneProjectOneWeek.Any(e => e.Id == id);
        }
    }
}
