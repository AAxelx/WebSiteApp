using WebSiteApp.Common.Enums;

namespace WebSiteApp.Models.Requests
{
    public class AddCartRequest
    {
        public string UserId { get; set; }
        public string ProductId { get; set; }
        public ProductTypeEnum Type { get; set; }
    }
}
