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

        public async Task<Root> GetKrisFeed()
        {
            var data = await Get("https://api.krisinformation.se/v1/feed?format=json");
            return JsonConvert.DeserializeObject<Root>(data);
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
    public class Author
    {
        public string Name { get; set; }
    }

    public class Link
    {
        public object Id { get; set; }
        public object LinkName { get; set; }
        public string LinkUrl { get; set; }
    }

    public class CapArea
    {
        public string CapAreaDesc { get; set; }
        public string Coordinate { get; set; }
    }

    public class Entry
    {
        public string ID { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Published { get; set; }
        public string CapEvent { get; set; }
        public Author Author { get; set; }
        public string Title { get; set; }
        public Link Link { get; set; }
        public string Summary { get; set; }
        public List<CapArea> CapArea { get; set; }
    }

    public class Root
    {
        public List<Entry> Entries { get; set; }
    }
}
