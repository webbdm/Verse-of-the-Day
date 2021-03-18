using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using webbdm_verse_of_the_day.Models;

namespace webbdm_verse_of_the_day.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoritesController : Controller

    {
        private readonly AppDbContext _context;

        public FavoritesController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Favorites()
        {
            ViewBag.favoriteVerses = _context.Verses.Where(v => v.HasBeenFavorited == true);

            return View("Favorites");
        }


    }
}
