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
    public class UserController : Controller
    {
        private readonly PortfolioDbContext _context;
        public UserController(PortfolioDbContext context)
        {
            _context = context;
        }
        public async Task<bool> UserSigninCheckAsync(string username, string userpassword)
        {
            UserInfo u = new UserInfo();
            u = await _context.users.FindAsync(1);

            if (u.UserName == username && u.UserPassword == userpassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> UpdatePasswordAsync(int id, string newPassword)
        {
            UserInfo userToBeUpdated = new UserInfo();
            userToBeUpdated = await _context.users.FindAsync(id);

            if (userToBeUpdated != null)
            {
                userToBeUpdated.UserPassword = newPassword;
                _context.users.Update(userToBeUpdated);
                await _context.SaveChangesAsync();
                return true;
            }
            else 
            {
                return false;
            }

        }
        public async Task<List<UserInfo>> GetAllUsersAsync()
        {
            return await _context.users.ToListAsync();
        }
    }
}
