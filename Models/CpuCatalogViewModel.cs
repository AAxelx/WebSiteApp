using WebSiteApp.Common.Enums;
using System.Collections.Generic;

namespace WebSiteApp.Models
{
    public class CpuCatalogViewModel
    {
        public IEnumerable<CpuModel> Cpus { get; set; }
        public int TotalRecords { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public SortedTypeEnum SortedType { get; set; }
    }
}
