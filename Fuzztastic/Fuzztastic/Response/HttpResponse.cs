namespace Fuzztastic.Response
{
    public class HttpResponse
    {
        private readonly int StatusCode;

        public HttpResponse(int statusCode) =>
            StatusCode = statusCode;

        public bool IsBetween(int minStatus, int maxStatus) => 
            StatusCode >= minStatus && StatusCode <= maxStatus;
    }
}
