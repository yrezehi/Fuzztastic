using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

namespace Fuzztastic.Specifications
{
    public class OpenAPILoader
    {
        private string Location { get; set; }
        private int Version { get; set; }
        private OpenApiDocument OpenApiDocument { get; set; }

        public OpenAPILoader(string location, int version)
        {
            (Location, Version, OpenApiDocument) = (location, version, GetDocument(GetFileAsStream(location)));
        }

        public static OpenAPILoader Instance(string location, int version) =>
            new OpenAPILoader(location, version);

        public OpenApiDocument GetSpecification() =>
            OpenApiDocument;

        public string Load() =>
            GetAsV2();

        private Stream GetFileAsStream(string location) =>
            new FileStream(location, FileMode.Open);

        private OpenApiDocument GetDocument(Stream stream) =>
            new OpenApiStreamReader().Read(stream, out _);

        private string GetAsV2() =>
           OpenApiDocument.Serialize(OpenApiSpecVersion.OpenApi2_0, OpenApiFormat.Json);
    }
}
