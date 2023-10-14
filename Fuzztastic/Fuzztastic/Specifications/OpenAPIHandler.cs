using Microsoft.OpenApi.Models;

namespace Fuzztastic.Specifications
{
    public class OpenAPIHandler
    {
        private OpenApiDocument Specification { get; set; }

        public OpenAPIHandler(OpenApiDocument specification) =>
            Specification = specification;
    }
}
