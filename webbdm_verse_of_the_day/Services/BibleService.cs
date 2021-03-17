using System;
using System.Net.Http;
using webbdm_verse_of_the_day.Helpers;
using System.Threading.Tasks;
using Newtonsoft.Json;

using webbdm_verse_of_the_day.Models;
using Microsoft.Extensions.Configuration;

namespace webbdm_verse_of_the_day.Services
{
    public class BibleService : IBibleService
    {
        private readonly HttpClient _client;
        private IConfiguration _configuration;

        public BibleService(IConfiguration configuration, HttpClient client)
        {
            _client = client;
            _configuration = configuration;
        }

        public async Task<VerseResponse> GetAllAsync(string startDate, int pageSize)
        {
            Uri requestURI = new Uri(_configuration.GetSection("Bible_API").GetSection("base_url").Value).
            AddQuery("startDate", startDate).
            AddQuery("pageSize", pageSize.ToString());

            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = requestURI,
                Headers = {
                { "Ocp-Apim-Subscription-Key", "d10161af8cf44f0c8267d571c682fda4" }
                }
            };

            var httpResponse = await _client.SendAsync(httpRequestMessage);

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve verses");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var verses = JsonConvert.DeserializeObject<VerseResponse>(content);

            return verses;
        }
    }
}