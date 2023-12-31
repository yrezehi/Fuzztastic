﻿using Microsoft.OpenApi.Models;

namespace Fuzztastic.Workers.Workload
{
    public class WorkloadGenerator
    {
        public static List<Workload> Generate(OpenApiDocument specification)
        {
            List<Workload> workloads = new List<Workload>();
            foreach (var path in specification.Paths){
                var operations = path.Value.Operations;

                foreach (var httpMethod in operations)
                {
                    operations.TryGetValue(httpMethod.Key, out OpenApiOperation? operation);

                    if(operation != null)
                    {
                        Workload workload = Workload.Request();

                        if (operation.RequestBody != null)
                        {
                            workload.WithBody(operation.RequestBody.Content.Keys.FirstOrDefault()!);
                        }
                     
                        foreach (var server in (operation.Servers.Count > 0 ? operation.Servers : specification.Servers))
                        {
                            workload.WithServer(server.Url);
                        }
                    }
                }
            }
            return workloads;
        }
    }
}
