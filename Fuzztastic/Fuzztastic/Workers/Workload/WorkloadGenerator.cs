using Microsoft.OpenApi.Models;

namespace Fuzztastic.Workers.Workload
{
    public class WorkloadGenerator
    {
        public WorkloadGenerator() { }

        public static void Generate(OpenApiDocument specification)
        {

            foreach (var path in specification.Paths){
                var operations = path.Value.Operations;

                foreach (var httpMethod in operations)
                {
                    operations.TryGetValue(httpMethod.Key, out OpenApiOperation? value);

                    if(value != null && value.Parameters.Count > 0)
                    {
                        foreach (var parameter in value.Parameters)
                        {

                        }
                    }
                }
            }

        }
    }
}
