using Newtonsoft.Json;
using System.Text;

namespace Fuzztastic.Http
{
    public class HttpClientBuilder
    {
        private HttpClient HttpClient { get; set; }
        private string HttpMethod { get; set; }
        private string URL { get; set; }
        private StringContent Body { get; set; }

        public static HttpClientBuilder Create() =>
            new HttpClientBuilder();

        public HttpClientBuilder WithHttpMethod(string method)
        {
            HttpMethod = method;
            return this;
        }

        public HttpClientBuilder WithUrl(string url)
        {
            URL = url;
            return this;
        }

        public HttpClientBuilder WithBody(object body)
        {
            Body = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

            return this;
        }

        public async Task<HttpResponseMessage> Execute()
        {
            HttpClient = new HttpClient();

            return HttpMethod switch
            {
                "GET" => await GetRequest(),
                _ => throw new ArgumentException($"No HTTP Method found for {HttpMethod}")
            };
        }

        private async Task<HttpResponseMessage> GetRequest() =>
            await HttpClient.GetAsync(URL);
        
        private async Task<HttpResponseMessage> PostReqiest() => 
            await HttpClient

    }
}
