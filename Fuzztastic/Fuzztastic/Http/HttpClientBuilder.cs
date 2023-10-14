namespace Fuzztastic.Http
{
    public class HttpClientBuilder
    {
        private HttpClient HttpClient { get; set; }
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

        public HttpResponseMessage Execute()
        {
            HttpClient = new HttpClient();

            return HttpMethod switch
            {
                "GET" => GetRequest(),
                _ => throw new ArgumentException($"No HTTP Method found for {HttpMethod}")
            };
        }

        private HttpResponseMessage GetRequest()
            {
                return null;
            }

    }
}
