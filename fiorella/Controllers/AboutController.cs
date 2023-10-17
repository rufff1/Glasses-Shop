using fiorella.DAL;
using fiorella.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Controllers
{
    public class AboutController : Controller
    {
        public readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;

        }


        public async Task<IActionResult>  Index()
        {

            AboutVM aboutVM = new AboutVM
            {
                WelcomeNest = await _context.WelcomeNests.FirstOrDefaultAsync(w => w.IsDeleted == false),
                Provides =await _context.Provides.Where(p=> p.IsDeleted == false).Take(6).ToListAsync(),
                OurPerformances = await _context.OurPerformances.FirstOrDefaultAsync(o=> o.IsDeleted == false),
                ExpertMeet = await _context.ExpertMeets.FirstOrDefaultAsync(e=> e.IsDeleted == false),
                OurTeams = await _context.OurTeams.Where(t=> t.IsDeleted == false).ToListAsync(),


            };
            return View(aboutVM);
        }
    }
}
