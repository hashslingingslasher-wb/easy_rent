using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EasyRent.Models;

namespace EasyRent.Controllers
{
    public class DataController : Controller
    {
        private readonly EasyRentDataContext _context;

        public DataController(EasyRentDataContext context)
        {
            _context = context;
        }

        // GET: Data
        public async Task<IActionResult> Index()
        {
              return _context.EasyRent != null ? 
                          View(await _context.EasyRent.ToListAsync()) :
                          Problem("Entity set 'EasyRentDataContext.EasyRent'  is null.");
        }

        // GET: Data/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EasyRent == null)
            {
                return NotFound();
            }

            var easyRent = await _context.EasyRent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (easyRent == null)
            {
                return NotFound();
            }

            return View(easyRent);
        }

        // GET: Data/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Data/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,IsRented,ReturnDate,Price,Notes")] EasyRentData easyRentData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(easyRentData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(easyRentData);
        }

        // GET: Data/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EasyRent == null)
            {
                return NotFound();
            }

            var easyRent = await _context.EasyRent.FindAsync(id);
            if (easyRent == null)
            {
                return NotFound();
            }
            return View(easyRent);
        }

        // POST: Data/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,IsRented,ReturnDate,Price,Notes")] EasyRentData easyRentData)
        {
            if (id != easyRentData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(easyRentData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EasyRentExists(easyRentData.Id))
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
            return View(easyRentData);
        }

        // GET: Data/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EasyRent == null)
            {
                return NotFound();
            }

            var easyRent = await _context.EasyRent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (easyRent == null)
            {
                return NotFound();
            }

            return View(easyRent);
        }

        // POST: Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EasyRent == null)
            {
                return Problem("Entity set 'EasyRentDataContext.EasyRent'  is null.");
            }
            var easyRent = await _context.EasyRent.FindAsync(id);
            if (easyRent != null)
            {
                _context.EasyRent.Remove(easyRent);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EasyRentExists(int id)
        {
          return (_context.EasyRent?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
