

using System.Collections.Generic;
using System.Threading.Tasks;
using webbdm_verse_of_the_day.Models;

namespace webbdm_verse_of_the_day.Services
{
    public interface IBibleService
    {
        Task<VerseResponse> GetAllAsync();

    }
}