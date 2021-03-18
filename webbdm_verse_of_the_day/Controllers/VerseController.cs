using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using webbdm_verse_of_the_day.Models;
using webbdm_verse_of_the_day.Models.ViewModels;
using webbdm_verse_of_the_day.Services;


namespace webbdm_verse_of_the_day.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

            ViewBag.verses =  GetVerses(verseRequest.StartDate, verseRequest.PageSize).Result.verses;

            return View("VerseResults");
        }

        [HttpPost("/favorite")]
        public bool SaveVerseToFavorites([FromForm] Verse verse) {


            // Create a new favorite using the verse
            Favorite fav = new Favorite { VerseId = verse.Id };

            _context.Favorites.Add(fav);
            _context.SaveChangesAsync();


            // Find the original verse
            Verse foundVerse = _context.Verses.Find(fav.VerseId);


            // Create if we have't favorite yet
            if (foundVerse == null)
            {
                // Mark as favorited
                verse.HasBeenFavorited = true;

                var createdVerse = _context.Verses.Add(verse);

                Console.WriteLine(createdVerse);
                Console.WriteLine("Created Verse");

            }
            else {

                // Update as favorited (if not created)
                foundVerse.HasBeenFavorited = true;
                Console.WriteLine($"{foundVerse.Book} {foundVerse.Chapter}:{foundVerse.VerseNumbers} has been saved To Favorites");

            }


            _context.SaveChangesAsync();


            return true;
        }

    }
}