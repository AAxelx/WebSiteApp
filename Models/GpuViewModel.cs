using WebSiteApp.Common.Enums;

namespace WebSiteApp.Models
{
    public class GpuViewModel
    {
        public GpuModel Cpu { get; set; }
        public int Page { get; set; }
        public SortedTypeEnum SortedType { get; set; }
    }
}
