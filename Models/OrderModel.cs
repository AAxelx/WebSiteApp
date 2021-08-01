using System;
using WebSiteApp.Common.Enums;

namespace WebSiteApp.Models
{
    public class OrderModel
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public OrderStatusEnum Status { get; set; }
    }
}
