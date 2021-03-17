using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using webbdm_verse_of_the_day.Models;
using webbdm_verse_of_the_day.Services;


namespace webbdm_verse_of_the_day.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VersesController : Controller

    {
        private readonly IBibleService _bible;

        public VersesController(IBibleService bible)
        {
            _bible = bible;
        }

        private async Task<VerseResponse> GetVerses(string startDate, int pageSize)
        {
            var verses = await _bible.GetAllAsync("03/16/2021", 4);

            return verses;
        }


        [HttpGet]
        public IActionResult Verses()
        {
            Task<VerseResponse> verses = GetVerses("03/16/2021", 4);
            var thing = verses.Result;


            ViewBag.verses = thing.verses;

            return View("Verses");
        }



    }
}