using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entery.IO
{
    public static class OpenAPI
    {
        public static bool Exists(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }

            return false;
        }
    }
}
