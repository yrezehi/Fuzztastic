using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzztastic.Specifications
{
    public class OpenAPIHandler
    {
        private OpenApiDocument Specification { get; set; }

        public OpenAPIHandler(OpenApiDocument specification) =>
            Specification = specification;
    }
}
