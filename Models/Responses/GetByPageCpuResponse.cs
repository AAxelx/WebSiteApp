using System.Collections.Generic;

namespace WebSiteApp.Models.Responses
{
    public class GetByPageCpuResponse
    {
        public IEnumerable<CpuModel> Cpus { get; set; }
        public int TotalRecords { get; set; }
    }
}
