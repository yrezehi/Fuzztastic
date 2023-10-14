using System.Net;

namespace Fuzztastic.Http
{
    public static class ProxySettings
    {
        private readonly static string PROXY_URL = default;
        private readonly static bool PROXY_BYPASS_ON_LOCAL = default;
        private readonly static bool PROXY_USE_DEFAULT_CREDENTIALS = default;

        private static WebProxy ProxyInstance =>
            new()
            {
                Address = new Uri(PROXY_URL),
                BypassProxyOnLocal = PROXY_BYPASS_ON_LOCAL,
                UseDefaultCredentials = PROXY_USE_DEFAULT_CREDENTIALS,
            };

        public static HttpClientHandler HttpClientHandlerInstance => 
            new()
            {
                Proxy = ProxyInstance
            };
    }
}
