using Microsoft.OpenApi.Models;

namespace Fuzztastic.Specifications
{
    public class OpenAPI
    {
        private OpenApiDocument Specification { get; set; }
        private Loader OpenAPILoader { get; set; }

        private readonly string Location;
        private readonly int Version;
        // Working on the fetching via network later!
        private bool IsViaNetwork { get; set; } = false;


        public OpenAPI(string location, int version)
        {
            if (!IsViaNetwork && !IsValidFileLocation(location))
                throw new ArgumentException("OpenAPI file was not found!");

            if (!IsHandledVersion(version))
                throw new ArgumentException("Invalid OpenAPI version!");

            OpenAPILoader = Loader.Instance(location, Version);

            (Location, Version, Specification) = (location, version, OpenAPILoader.GetSpecification());
        }

        private static bool IsHandledVersion(int version) =>
            new int[] { 2, 3 }.Contains(version);

        private static bool IsValidFileLocation(string fileLocation) =>
            new FileInfo(fileLocation).Exists;

        public override string ToString() =>
            Loader.Instance(Location, Version).Load();
    }
}
