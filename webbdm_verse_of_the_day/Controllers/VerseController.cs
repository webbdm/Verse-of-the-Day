using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

using webbdm_verse_of_the_day.Models;
using webbdm_verse_of_the_day.Services;

using Newtonsoft.Json;
using System.Threading.Tasks;

namespace webbdm_verse_of_the_day.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VersesController : ControllerBase

    {

        public VersesController(AppDbContext appDbContext)
        {
        }


        [HttpGet]
        public async Task<VerseResponse> GetVerses()
        {
            var services = new ServiceCollection();
            services.UseServices();

            var serviceProvider = services.BuildServiceProvider();

            var service = serviceProvider.GetRequiredService<IBibleService>();

            var verses = await service.GetAllAsync();

            return verses;
        }



    }
}