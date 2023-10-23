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
            
        public async Task<IActionResult> BlogDetail(int? id)
        {
            if (! await _context.Blogs.AnyAsync(b=> b.Id == id))
            {
                return NotFound("Melumat yalnisdir");
            }

            BlogVM blogVM = new BlogVM()
            {
                Blog = await _context.Blogs
                .Include(b=> b.Category)
                 .Include(b=> b.BlogTags)
                 .ThenInclude(bt=> bt.Tag)
                .FirstOrDefaultAsync(b=> b.IsDeleted == false)

            };

            return View(blogVM);
        }


        public async Task<IActionResult> TagFindBlog(int? id)
        {


        

            BlogVM blogVM = new BlogVM()
            {
                Blogs = await _context.Blogs
                .Include(b => b.Category)
                .Include(b => b.BlogTags)
                .ThenInclude(bt => bt.Tag)
                .Where(b => b.IsDeleted == false  && b.BlogTags.Any(b=> b.TagId == id)).ToListAsync()
            };


            if (blogVM.Blogs==null)
            {
                return NotFound("Id tapilmadi");
            }


            if (blogVM.Blogs.Count()== 0)
            {
                return NotFound("Bu Tagle babgli blog yoxdur");
            }


            return View(blogVM);

        }


        public async Task<IActionResult> GetCategoryBlog(int? id)
        {



            BlogVM blogVM = new BlogVM()
            {
                Blogs = await _context.Blogs
                .Include(b => b.Category)
                .Include(b => b.BlogTags)
                .ThenInclude(bt=> bt.Tag)
                .Where(b=> b.IsDeleted ==false).ToListAsync()


            };

            if (blogVM.Blogs == null)
            {
                return NotFound("melumat yalnisdir");
            }

            if (blogVM.Categories.Count()<1)
            {
                return NotFound("bu categoriyaya aid blog tapilmadi");
            }


            return View(blogVM);
        }

    }
}
