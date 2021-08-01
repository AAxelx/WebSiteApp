using System.Collections.Generic;

namespace WebSiteApp.Models.Responses
{
    public class GetByPageOrderResponse
    {
        public IEnumerable<OrderModel> Orders { get; set; }
        public int TotalOrders { get; set; }
    }
}
