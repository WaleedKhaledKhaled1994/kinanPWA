using System;
using System.Collections.Generic;

namespace PWA.Shared.Entities
{
    public partial class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool OutOfStock { get; set; }
        public int SubCatId { get; set; }
        public bool? Status { get; set; }
        public string Image { get; set; }

        public virtual SubCategory SubCategory { get; set; }
    }
}
