using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using System.IO;

namespace Fuzztastic.Specifications
{
    public class Loader
    {
        private string Location { get; set; }
        private int Version { get; set; }
        private OpenApiDocument OpenApiDocument { get; set; }

        public Loader(string location, int version)
        {
            (Location, Version, OpenApiDocument) = (location, version, GetDocument(GetFileAsStream()));
        }

        public static Loader Instance(string location, int version) =>
            new Loader(location, version);

        public OpenApiDocument GetSpecification() =>
            OpenApiDocument;

        public string Load() =>
            GetAsV2();

        private Stream GetFileAsStream() =>
            new FileStream(Location, FileMode.Open);

        private OpenApiDocument GetDocument(Stream stream) =>
            new OpenApiStreamReader().Read(stream, out _);

        private string GetAsV2() =>
           OpenApiDocument.Serialize(OpenApiSpecVersion.OpenApi2_0, OpenApiFormat.Json);
    }
}
