using System;
using WebSiteApp.Common.Enums;

namespace WebSiteApp.Models
{
    public class GpuModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Price { get; set; }
        public DateTime CreateDate { get; set; }
        public ProductTypeEnum Type { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
