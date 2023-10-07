using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzztastic.Workers.Workload
{
    public class Workload
    {
        private int? Id { get; set; }
        private string? Server { get; set; }
        private string? HttpMethod { get; set; }
        private string? Endpoint { get; set; }
        private string? OperationId { get; set; }
        private string? BodyPayload { get; set; }


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

        public Workload WithBody(string body)
        {
            BodyPayload = body;
            return this;
        }
    }
}
