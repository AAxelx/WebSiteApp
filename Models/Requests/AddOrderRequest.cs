using System.Collections.Generic;

namespace WebSiteApp.Models.Requests
{
    public class AddOrderRequest
    {
        public string UserId { get; set; }
        public List<CartProductModel> Products { get; set; }
    }
}
