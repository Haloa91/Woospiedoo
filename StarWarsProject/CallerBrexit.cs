using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace StarWarsProject
{
    internal class CallerBrexit
    {
        public static HttpClient _client { get; set; }
        public CallerBrexit()
        {
            HttpClient client = new HttpClient();
            _client = client;
        }

        internal string Call(string protagonist)
        {
            _client.BaseAddress= new Uri("https://swapi.co/api/people/");
            var response=_client.GetAsync(protagonist).GetAwaiter().GetResult();
            JObject res = JsonConvert.DeserializeObject<JObject>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
           return res.SelectToken("name").Value<string>();
        }
    }
}