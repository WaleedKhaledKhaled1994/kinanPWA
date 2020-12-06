using System;
using System.Collections.Generic;

namespace PWA.Shared.Entities
{
    public partial class SubCategory
    {
        public SubCategory()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public bool? Status { get; set; }

        public virtual Category Category { get; set; }
        public virtual  ICollection<Product> Product { get; set; }
    }
}
