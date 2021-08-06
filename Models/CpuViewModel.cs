using WebSiteApp.Common.Enums;

namespace WebSiteApp.Models
{
    public class CpuViewModel
    {
        public CpuModel Cpu { get; set; }
        public int Page { get; set; }
        public SortedTypeEnum SortedType { get; set; }
    }
}
