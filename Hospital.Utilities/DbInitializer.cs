﻿using Hospital.Models;
using Hospital.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Utilities
{
    public class DbInitializer : IDbInitializer
    {
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private ApplicationDbContext _context;

        public DbInitializer(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        public void Initialize() 
        {
            try
            {
                if (_context.Database.GetPendingMigrations().Count() > 0)
                {
                    _context.Database.Migrate();
                }
            }
            catch (Exception)
            {
                throw;
            }
            if (!_roleManager.RoleExistsAsync(WebSiteRules.WebSite_Admin).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(WebSiteRules.WebSite_Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebSiteRules.WebSite_Patient)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebSiteRules.WebSite_Doctor)).GetAwaiter().GetResult();
            }

            var AppUser = _context.ApplicationUsers.FirstOrDefault(x => x.Email == "info@sefamaril.com");
            if (AppUser == null)
            {
                var result = _userManager.CreateAsync(new User
                {
                    UserName = "sefamaril",
                    Email = "info@sefamaril.com"

                }, "Sefa@123").GetAwaiter().GetResult();
            }
            AppUser = _context.ApplicationUsers.FirstOrDefault(x => x.Email == "info@sefamaril.com");


            if (!(_userManager.IsInRoleAsync(AppUser, WebSiteRules.WebSite_Admin).GetAwaiter().GetResult()))
            {
                _userManager.AddToRoleAsync(AppUser, WebSiteRules.WebSite_Admin).GetAwaiter().GetResult();
            }
        }
    }
}
