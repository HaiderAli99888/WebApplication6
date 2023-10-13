using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Data;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class SlippersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SlippersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Slippers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Slippers.ToListAsync());
        }

        // GET: Slippers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slipper = await _context.Slippers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (slipper == null)
            {
                return NotFound();
            }

            return View(slipper);
        }

        // GET: Slippers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Slippers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Price,ImageUrl,Description,Material,Brand,CustomerReview")] Slipper slipper)
        {
            if (ModelState.IsValid)
            {
                _context.Add(slipper);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(slipper);
        }

        // GET: Slippers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slipper = await _context.Slippers.FindAsync(id);
            if (slipper == null)
            {
                return NotFound();
            }
            return View(slipper);
        }

        // POST: Slippers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Price,ImageUrl,Description,Material,Brand,CustomerReview")] Slipper slipper)
        {
            if (id != slipper.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(slipper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlipperExists(slipper.ID))
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
            return View(slipper);
        }

        // GET: Slippers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slipper = await _context.Slippers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (slipper == null)
            {
                return NotFound();
            }

            return View(slipper);
        }

        // POST: Slippers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var slipper = await _context.Slippers.FindAsync(id);
            _context.Slippers.Remove(slipper);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SlipperExists(int id)
        {
            return _context.Slippers.Any(e => e.ID == id);
        }
    }
}
