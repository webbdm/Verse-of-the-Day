using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using webbdm_verse_of_the_day.Models;
using webbdm_verse_of_the_day.Models.ViewModels;
using webbdm_verse_of_the_day.Services;


namespace webbdm_verse_of_the_day.Controllers
{
    [ApiController]
    [Route("/")]
    public class VersesController : Controller

    {
        private readonly IBibleService _bible;
        private readonly AppDbContext _context;

        public VersesController(IBibleService bible, AppDbContext context)
        {
            _bible = bible;
            _context = context;
        }

        private async Task<VerseResponse> GetVerses(string startDate, int pageSize)
        {
            return await _bible.GetAllAsync(startDate, pageSize);
        }


        [HttpGet]
        public IActionResult Verses()
        {
            return View("VerseForm");
        }

        [HttpPost]
        public IActionResult SendVerse([FromForm] VerseRequest verseRequest)
        {
            try
            {
                ViewBag.verses = GetVerses(verseRequest.StartDate, verseRequest.PageSize).Result.verses;

            }
            catch (Exception)
            {

                ViewBag.verses =  new List<string>();
                ModelState.AddModelError("error_msg", " ");
            }
                return View("VerseResults");
        }

        [HttpPost("/favorited")]
        public StatusCodeResult SaveVerseToFavorites([FromBody] Verse verse)
        {


            // We store verses in the verses table and build up a cache over time in the db
            // Check if a copy of the verse already exists
            Verse foundVerse = _context.Verses.Find(verse.Id);


            // Do nothing, Verse is already stored and a favorite exists
            if (foundVerse != null) return StatusCode(204);


            // Create the Verse and store a record in Favorites
            if (foundVerse == null)
            {
                // Mark as favorited
                verse.HasBeenFavorited = true;
                _context.Verses.Add(verse);


                // Create a new favorite using the verse
                Favorite fav = new Favorite { VerseId = verse.Id };

                _context.Favorites.Add(fav);
            }

            _context.SaveChangesAsync();

            return StatusCode(200);

        }
    }
}