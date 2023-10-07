namespace Fuzztastic.OpenAPI
{
    public class OpenAPI
    {
        private readonly string Location;
        private readonly int Version;
        // Working on the fetching via network later!
        private bool IsViaNetwork { get; set; } = false;

        public OpenAPI(string location, int version)
        {
            if (!IsViaNetwork && IsValidFileLocation(location))
                throw new ArgumentException("OpenAPI file was not found!");

            if (!IsHandledVersion(version))
                throw new ArgumentException("Invalid OpenAPI version!");

            (Location, Version) = (location, version);
        }

        private static bool IsHandledVersion(int version) =>
            new int[] { 2, 3 }.Contains(version);

        private static bool IsValidFileLocation(string fileLocation) =>
            File.Exists(fileLocation);
    }
}
