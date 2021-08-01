using System.Collections.Generic;

namespace WebSiteApp.Models.Responses
{
    public class GetCartResponse
    {
        public List<CartProductModel> CartProducts { get; set; } = null!;
    }
}
