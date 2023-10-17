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
    public class BlogController : Controller
    {
        public readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int pageIndex)
        {
            BlogVM blogVM = new BlogVM
            {
                Blog = await _context.Blogs
                .Include(b=> b.Category)
                .Include(b=> b.BlogTags)
                .ThenInclude(bt=> bt.Tag)
                .FirstOrDefaultAsync(b => b.IsDeleted == false),

                Categories = await _context.Categories.Include(b => b.Blogs).Where(b => b.IsDeleted == false).ToListAsync(),
                Tags = await _context.Tags.Where(b => b.IsDeleted == false).ToListAsync(),
                Blogs = await _context.Blogs

            .Where(b => b.IsDeleted == false).ToListAsync(),




            };

            int totalPages = (int)Math.Ceiling((decimal)blogVM.Blogs.Count() / 7);
            if (pageIndex < 1 || pageIndex > totalPages)
            {
                pageIndex = 1;
            }

            blogVM.Blogs = blogVM.Blogs.Skip((pageIndex - 1) * 3).Take(8).ToList();
            ViewBag.totalpages = totalPages;
            ViewBag.pageIndex = pageIndex;

            return View(blogVM);
        }
            

    }
}
