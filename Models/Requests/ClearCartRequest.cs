using WebSiteApp.Common.Enums;

namespace WebSiteApp.Models.Requests
{
    public class ClearCartRequest
    {
        public string UserId { get; set; }
        public ProductTypeEnum ProductType { get; set; }
        public string ProductId { get; set; }
    }
}
