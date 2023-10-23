using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Controllers
{
    public class ShopController : Controller
    {
        public async Task<IActionResult> Index()
        {



            return View();
        }

        public async Task<IActionResult> ShopDetail()
        {

            return View();
        }
    }
}
