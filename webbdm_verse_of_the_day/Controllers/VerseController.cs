using System;
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

        public VersesController(IBibleService bible)
        {
            _bible = bible;
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

    }
}