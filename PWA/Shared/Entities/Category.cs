using System;
using System.Collections.Generic;

namespace PWA.Shared.Entities
{
    public partial class Category
    {
        public Category()
        {
            SubCategory = new HashSet<SubCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<SubCategory> SubCategory { get; set; }
    }
}
