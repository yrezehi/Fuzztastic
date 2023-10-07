namespace Fuzztastic.Http
{
    public class HttpClientBuilder
    {
        private HttpClient HttpClient;

        private string HttpMethod { get; set; }
        private string URL { get; set; }
        private string Body { get; set; }

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

        public HttpClientBuilder WithBody(string body)
        {
            Body = body;
            return this;
        }

    }
}
