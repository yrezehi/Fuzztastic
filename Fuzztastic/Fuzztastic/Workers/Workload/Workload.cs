using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzztastic.Workers.Workload
{
    public class Workload
    {
        public int? Id { get; set; }
        public string? Server { get; set; }
        public string? HttpMethod { get; set; }
        public string? Endpoint { get; set; }
        public string? OperationId { get; set; }


        public static Workload Request()
        {
            return new Workload();
        }

        public Workload WithId(int id)
        {
            Id = id;
            return this;
        }

        public Workload WithServer(string server)
        {
            Server = server;
            return this;
        }

        public Workload WithMethod(string method)
        {
            HttpMethod = method;
            return this;
        }

        public Workload WithEndpoint(string endpoint)
        {
            Endpoint = endpoint;
            return this;
        }

        public Workload WithOperationId(string operationId)
        {
            OperationId = operationId;
            return this;
        }
    }
}
