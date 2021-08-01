using System.Collections.Generic;

namespace WebSiteApp.Models.Responses
{
    public class GetByPageGpuResponse
    {
        public IEnumerable<GpuModel> Gpus { get; set; }
        public int TotalRecords { get; set; }
    }
}
