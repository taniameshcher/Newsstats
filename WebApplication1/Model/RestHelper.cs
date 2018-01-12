using Newtonsoft.Json;
using System.Net.Http;

namespace WebApplication1.Model
{
    public static class RestHelper
    {
        public static T RestGet<T>(string uri)
        {
            var httpClient = new HttpClient();
            HttpResponseMessage resp = httpClient.GetAsync(uri).GetAwaiter().GetResult();
            string content = resp.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            T result = JsonConvert.DeserializeObject<T>(content);
            return result;
        }
    }
}
