using System.Collections.Generic;

namespace WebSiteApp.Models
{
    public class GetByIdOrderViewModel
    {
        public string OrderId { get; set; }
        public List<CartProductModel> Products { get; set; }
    }
}
