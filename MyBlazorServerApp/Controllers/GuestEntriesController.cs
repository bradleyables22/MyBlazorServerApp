#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyBlazorServerApp.Data;
using MyBlazorServerApp.Data.Models;

namespace MyBlazorServerApp.Controllers
{
    public class GuestEntriesController : Controller
    {
        private readonly PortfolioDbContext _context;

        public GuestEntriesController(PortfolioDbContext context)
        {
            _context = context;
        }

        //return list of entries
        public async Task<List<GuestEntry>> GetGuestEntryAsync()
        {
            return await _context.GuestEntries.ToListAsync();
        }
        //enters entry into DB. Returns success or fail
        public async Task<bool> CreateEntryAsync(GuestEntry guestEntry)
        {
            
            _context.GuestEntries.Add(guestEntry);
            //Not necessary but keeps method Async 
            await _context.SaveChangesAsync();  
            return true;
        }
        public async Task<bool> DeleteEntryAsync(int id)
        {
            var entry = await _context.GuestEntries.FindAsync(id);

            if (entry == null)
            {
                return false;
            }
            else
            {
                _context.GuestEntries.Remove(entry);
                return true;
            }
        }

        // GET: GuestEntries
        public async Task<IActionResult> Index()
        {
            return View(await _context.GuestEntries.ToListAsync());
        }

        // GET: GuestEntries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guestEntry = await _context.GuestEntries
                .FirstOrDefaultAsync(m => m.GuestEntryID == id);
            if (guestEntry == null)
            {
                return NotFound();
            }

            return View(guestEntry);
        }

        // GET: GuestEntries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GuestEntries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GuestEntryID,GuestName,EntryTimeDate,GuestInput")] GuestEntry guestEntry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guestEntry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(guestEntry);
        }

        // GET: GuestEntries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guestEntry = await _context.GuestEntries.FindAsync(id);
            if (guestEntry == null)
            {
                return NotFound();
            }
            return View(guestEntry);
        }

        // POST: GuestEntries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GuestEntryID,GuestName,EntryTimeDate,GuestInput")] GuestEntry guestEntry)
        {
            if (id != guestEntry.GuestEntryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guestEntry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GuestEntryExists(guestEntry.GuestEntryID))
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
            return View(guestEntry);
        }

        // GET: GuestEntries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guestEntry = await _context.GuestEntries
                .FirstOrDefaultAsync(m => m.GuestEntryID == id);
            if (guestEntry == null)
            {
                return NotFound();
            }

            return View(guestEntry);
        }

        // POST: GuestEntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var guestEntry = await _context.GuestEntries.FindAsync(id);
            _context.GuestEntries.Remove(guestEntry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GuestEntryExists(int id)
        {
            return _context.GuestEntries.Any(e => e.GuestEntryID == id);
        }
    }
}
