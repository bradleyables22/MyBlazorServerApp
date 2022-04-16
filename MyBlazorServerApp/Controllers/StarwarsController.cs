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
    public class StarwarsController : Controller
    {
        private readonly PortfolioDbContext _context;
        public StarwarsController(PortfolioDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAffiliationAsync(StarWarsAffiliation swa)
        {

            _context.StarWarsAffiliations.Add(swa);
            //Not necessary but keeps method Async 
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteAffiliationAsync(int id)
        {
            var starWarsAffiliation = await _context.StarWarsAffiliations.FindAsync(id);

            if (starWarsAffiliation == null)
            {
                return false;
            }
            else
            {
                _context.StarWarsAffiliations.Remove(starWarsAffiliation);
                await _context.SaveChangesAsync();
                return true;
            }
        }
        public async Task<int> GetJediCountAsync()
        {
            string jedi = "j";
            return await _context.StarWarsAffiliations.CountAsync(e => e.Affiliation == jedi);
        }
        public async Task<int> GetSithCountAsync()
        {
            string sith = "s";
            return await _context.StarWarsAffiliations.CountAsync(e => e.Affiliation == sith);
        }
        public async Task<bool> ResetCountAsync()
        {
            List<StarWarsAffiliation> swaList = new List<StarWarsAffiliation>();

            swaList = await _context.StarWarsAffiliations.ToListAsync();

            foreach (var affiliation in swaList)
            {
                _context.StarWarsAffiliations.Remove(affiliation);
                await _context.SaveChangesAsync();
            }
            return true;
        }

    }
}
