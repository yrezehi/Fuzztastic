namespace Fuzztastic.Defects
{
    public class Defects
    {
        private void LoadDefaultDefects(string defectPath)
        {
            if(!File.Exists(defectPath))
                throw new FileNotFoundException(defectPath);
        }

    }
}
