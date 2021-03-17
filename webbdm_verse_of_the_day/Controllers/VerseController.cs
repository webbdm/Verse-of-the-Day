using System.Threading.Tasks;
using System;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

using webbdm_verse_of_the_day.Models;
using webbdm_verse_of_the_day.Services;


namespace webbdm_verse_of_the_day.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VersesController : ControllerBase

    {
        private readonly IBibleService _bible;

        public VersesController(AppDbContext appDbContext, IBibleService bible)
        {
            _bible = bible;
        }


        [HttpGet]
        public async Task<VerseResponse> GetVerses(string startDate, int pageSize)
        {
            var verses = await _bible.GetAllAsync("03/16/2021", 4);

            return verses;
        }



    }
}