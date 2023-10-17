using fiorella.DAL;
using fiorella.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Controllers
{

  


    public class ContactController : Controller
    {
        public readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Location> locations = await _context.Locations.Where(l => l.IsDeleted == false).Take(3).ToListAsync();

            return View(locations);
        }
    }
}
