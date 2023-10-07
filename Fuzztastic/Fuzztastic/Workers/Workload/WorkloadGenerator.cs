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
                    operations.TryGetValue(httpMethod.Key, out OpenApiOperation? operation);

                    if(operation != null)
                    {
                        if (operation.RequestBody != null)
                        {
                            // request body
                        }

                        foreach (var server in operation.Servers)
                        {
                            // servers
                        }
                    }
                }
            }

        }
    }
}
