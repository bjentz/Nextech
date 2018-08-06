using System;
using System.Threading.Tasks;
using Nextech.Domain;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Collections.Generic;

namespace Nextech.Data
{
    public class HackerNewsRepository : IHakerNewsRepository<Article>
    {
        private HttpClient _client;
        private string _addressRoot = "https://hacker-news.firebaseio.com/v0";
        private string _idPath = "/beststories/"; //TODO: use config and inject it
        private string _itemPath = "/item/";
        private string _addressSufix = ".json?print=pretty";
        public HackerNewsRepository(HttpClient client)
        {
            _client = client;
        }
        public async Task< IEnumerable<int>> ReadIdsasync()
        {
                string idList = await _client.GetStringAsync($"{ _addressRoot}{ _idPath}{ _addressSufix}");
                var ids = Newtonsoft.Json.JsonConvert.DeserializeObject<int[]>(idList);
                return ids;
        }

        public async Task<Article> ReadItemasync(int Id)
        {
                HttpResponseMessage itemMessage = await _client.GetAsync($"{_addressRoot}{_itemPath}{Id}{_addressSufix}");
                return await itemMessage.Content.ReadAsAsync<Article>();
        }
    }
}
