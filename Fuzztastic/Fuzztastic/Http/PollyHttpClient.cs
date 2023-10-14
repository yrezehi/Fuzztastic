using Polly;
using Polly.Retry;
using System;

namespace Fuzztastic.Http
{
    public class PollyHttpClient
    {
        private readonly static int MAX_RETRY_ATTEMPTS= 3;
        private readonly static TimeSpan WAIT_BEFORE_RETRY = TimeSpan.FromSeconds(1);

        public AsyncRetryPolicy<HttpResponseMessage> PollyPlicy =>
            Policy.Handle<HttpRequestException>()
                .OrResult<HttpResponseMessage>(response => !response.IsSuccessStatusCode)
                    .WaitAndRetryAsync(MAX_RETRY_ATTEMPTS, sleepProvider => WAIT_BEFORE_RETRY, OnRetry);

        private void OnRetry(DelegateResult<HttpResponseMessage> result, TimeSpan span, int retryCount, Context context) =>
            Console.WriteLine($"Retrey: #{retryCount} with reason: {result.Exception.Message}");
    }
}
