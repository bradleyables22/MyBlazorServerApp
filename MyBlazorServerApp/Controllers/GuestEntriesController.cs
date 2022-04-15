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
    }
}
