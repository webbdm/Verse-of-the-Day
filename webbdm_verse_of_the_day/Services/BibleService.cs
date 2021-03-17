using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using webbdm_verse_of_the_day.Models;

namespace webbdm_verse_of_the_day.Services
{
    public class BibleService : IBibleService
    {
        private const string BaseUrl = "https://emfservicesstage-api.azure-api.net/bible/v1/getversesbydate?siteId=1&?startdate=03/16/2021&PageSize=10";

        private readonly HttpClient _client;

        public BibleService(HttpClient client)
        {
            _client = client;
        }

        public async Task<VerseResponse> GetAllAsync()
        {
            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://emfservicesstage-api.azure-api.net/bible/v1/getversesbydate?siteId=1&startdate=03/16/2021&PageSize=10"),
                Headers = {
                { "Ocp-Apim-Subscription-Key", "d10161af8cf44f0c8267d571c682fda4" }
                }
            };

            var httpResponse = await _client.SendAsync(httpRequestMessage);

            if (!httpResponse.IsSuccessStatusCode)
            {
                Console.WriteLine(httpResponse);
                throw new Exception("Cannot retrieve verses");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var verses = JsonConvert.DeserializeObject<VerseResponse>(content);

            return verses;
        }
    }
}