using Fuzztastic.Response;
using Newtonsoft.Json;
using System.Text;

namespace Fuzztastic.Request
{
    public class HttpRequest
    {
        private HttpClient HttpClient { get; set; }
        private string HttpMethod { get; set; }
        private string URL { get; set; }
        private StringContent Body { get; set; }

        public static HttpRequest Create(string method)
        {
            HttpRequest request = new HttpRequest();
            request.HttpMethod = method.ToUpper();
            return request;
        }

        public HttpRequest WithUrl(string url)
        {
            URL = url;
            return this;
        }

        public HttpRequest WithBody(object body)
        {
            Body = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            return this;
        }

        public async Task<HttpResponse> Execute()
        {
            HttpClient = new HttpClient();

            return new HttpResponse(HttpMethod switch
            {
                "GET" => await GetRequest(),
                "POST" => await PostRequest(),
                "PUT" => await PutRequest(),
                "DELETE" => await DeleteRequest(),
                _ => throw new ArgumentException($"No HTTP Method found for {HttpMethod}")
            });
        }

        private async Task<HttpResponseMessage> GetRequest() =>
            await HttpClient.GetAsync(URL);
        private async Task<HttpResponseMessage> PostRequest() =>
            await HttpClient.PostAsync(URL, Body);
        private async Task<HttpResponseMessage> PutRequest() =>
            await HttpClient.PutAsync(URL, Body);
        private async Task<HttpResponseMessage> DeleteRequest() =>
            await HttpClient.DeleteAsync(URL);
    }
}
