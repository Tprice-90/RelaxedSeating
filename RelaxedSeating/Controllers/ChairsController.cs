﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RelaxedSeating.Data;
using RelaxedSeating.Models;

namespace RelaxedSeating.Controllers
{
    public class ChairsController : Controller
    {
        private readonly RelaxedSeatingContext _context;

        public ChairsController(RelaxedSeatingContext context)
        {
            _context = context;
        }

        // GET: Chairs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Chair.ToListAsync());
        }

        // GET: Chairs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chair = await _context.Chair
                .FirstOrDefaultAsync(m => m.ChairId == id);
            if (chair == null)
            {
                return NotFound();
            }

            return View(chair);
        }

        // GET: Chairs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Chairs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ChairId,Name,Material,DateMade,Price")] Chair chair)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chair);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chair);
        }

        // GET: Chairs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chair = await _context.Chair.FindAsync(id);
            if (chair == null)
            {
                return NotFound();
            }
            return View(chair);
        }

        // POST: Chairs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ChairId,Name,Material,DateMade,Price")] Chair chair)
        {
            if (id != chair.ChairId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chair);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChairExists(chair.ChairId))
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
            return View(chair);
        }

        // GET: Chairs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chair = await _context.Chair
                .FirstOrDefaultAsync(m => m.ChairId == id);
            if (chair == null)
            {
                return NotFound();
            }

            return View(chair);
        }

        // POST: Chairs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chair = await _context.Chair.FindAsync(id);
            _context.Chair.Remove(chair);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChairExists(int id)
        {
            return _context.Chair.Any(e => e.ChairId == id);
        }
    }
}
