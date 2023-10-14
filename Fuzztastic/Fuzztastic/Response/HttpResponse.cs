namespace Fuzztastic.Response
{
    public class HttpResponse
    {
        private readonly int StatusCode;
        private string? Description { get; set; }

        public HttpResponse(HttpResponseMessage response) =>
            StatusCode = (int) response.StatusCode;

        public bool Is1xx => IsBetween(100, 199);
        public bool Is2xx => IsBetween(200, 299);
        public bool Is3xx => IsBetween(300, 399);
        public bool Is4xx => IsBetween(400, 499);
        public bool Is5xx => IsBetween(500, 599);

        private bool IsBetween(int minStatus, int maxStatus) => 
            StatusCode >= minStatus && StatusCode <= maxStatus;
    }
}
