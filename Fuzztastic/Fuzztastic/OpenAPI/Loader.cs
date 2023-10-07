using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzztastic.OpenAPI
{
    public class Loader
    {
        private string Location { get; set; }

        public Loader(string location) => 
            Location = location;

        public static Loader Instance(string location, int version)
        {
            return new Loader(location);
        }

        public string Load()
        {
            var openApiDocument = new OpenApiStreamReader().Read(stream, out var diagnostic);
        }
    }
}
