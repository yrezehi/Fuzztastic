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
