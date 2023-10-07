using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzztastic.Workers.Workload
{
    public class WorkloadRequest
    {
        public int Id { get; set; }
        public string Server { get; set; }
        public string HttpMethod { get; set; }
        public string Endpoint { get; set; }
        public string OperationId { get; set; }
    }
}
