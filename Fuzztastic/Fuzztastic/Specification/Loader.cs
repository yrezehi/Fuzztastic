using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
namespace Fuzztastic.Specification
{
    public class Loader
    {
        private string Location { get; set; }
        private int Version { get; set; }

        public Loader(string location, int version) =>
            (Location, Version) = (location, version);

        public static Loader Instance(string location, int version) =>
            new Loader(location, version);

        public string Load() =>
            ReadV2(GetFileAsStream());

        private Stream GetFileAsStream() =>
            new FileStream(Location, FileMode.Open);

        private string ReadV2(Stream stream) =>
            new OpenApiStreamReader().Read(stream, out _).Serialize(OpenApiSpecVersion.OpenApi2_0, OpenApiFormat.Json);
    }
}
