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
            // Value for the Ocp-Apim-Subscription-Key found in appsettings.json
            string subscriptionKey = _configuration.GetSection("Bible_API").GetSection("subscription_key_header_value").Value;

            Uri requestURI = new Uri(_configuration.GetSection("Bible_API").GetSection("base_url").Value).
            AddQuery("startDate", startDate).
            AddQuery("pageSize", pageSize.ToString());

            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = requestURI,
                Headers = {
                { "Ocp-Apim-Subscription-Key", subscriptionKey }
                }
            };

            var httpResponse = await _client.SendAsync(httpRequestMessage);

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve verses");
            }

             return JsonConvert.DeserializeObject<VerseResponse>(await httpResponse.Content.ReadAsStringAsync());

           
        }
    }
}