using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzztastic.OpenAPI
{
    public class OpenAPI
    {
        private readonly string Location;
        private readonly int Version;
        // Working on the fetching via network later!
        private bool IsViaNetwork { get; set; } = false;

        public OpenAPI(string location, int version) =>
            (Location, Version) = (location, version);
    }
}
