using Fuzztastic.Specifications;

namespace Fuzztastic.Expermintal
{
    public class Expermintal {

        private static string SPECIFICATION_PATH = "Expermintal\\specification.yaml";
        private readonly OpenAPI OpenAPI;

        public Expermintal()
        {
            string specificationLocation = Path.Combine(Environment.CurrentDirectory, SPECIFICATION_PATH);
            
            OpenAPI = new OpenAPI(specificationLocation, 3);
        }

        public string GetSpecification() =>
            OpenAPI.ToString();
    }
}
