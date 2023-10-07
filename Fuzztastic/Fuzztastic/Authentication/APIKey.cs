using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzztastic.Authentication
{
    public class APIKey
    {
        private readonly string Value;

        public APIKey(string value) =>
            Value = value;
    }
}
