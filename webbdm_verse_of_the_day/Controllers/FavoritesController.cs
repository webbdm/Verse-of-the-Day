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
    public class FavoritesController : ControllerBase

    {
        private readonly AppDbContext _appDbContext;

        public FavoritesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        [HttpGet]
        public IActionResult GetAllFavorites()
        {
            return Ok(_appDbContext.Favorites);
        }



    }
}
