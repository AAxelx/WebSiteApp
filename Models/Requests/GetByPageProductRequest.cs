using WebSiteApp.Common.Enums;

namespace WebSiteApp.Models.Requests
{
    public class GetByPageProductRequest
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public SortedTypeEnum SortedType { get; set; }
    }
}
