using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace GoGoBoB0.Services
{
    public class ApiService : IApiService
    {
        static readonly HttpClient client = new HttpClient();

        public async Task<string[]> Get()
        {
            var data = await Get("http://api.krisinformation.se/v1/themes?format=json");
            return JsonConvert.DeserializeObject<string[]>(data);
        }

        public async Task<string> Get(string url)
        {
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return "";
        }
    }
}
