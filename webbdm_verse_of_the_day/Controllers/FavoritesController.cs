using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var yay = _context.Favorites
                .Include(f => f.Verse).ToList();

            ViewBag.favorites = _context.Favorites
                .Include(f => f.Verse).ToList();


            return View("Favorites");
        }

        // Stretch Goal
        [HttpPost("/unfavorite")]
        public IActionResult Unfavorite([FromForm] string verseId)
        {

            var yay = _context.Favorites.Where(f => f.VerseId == verseId);

            _context.Favorites.Remove(_context.Favorites.Where(f=>f.VerseId == verseId).Single());

            ViewBag.favoriteVerses = _context.Verses.Where(v => v.HasBeenFavorited == true);

            return View("Favorites");

        }

    }
}
