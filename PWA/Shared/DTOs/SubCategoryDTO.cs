
using PWA.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PWA.Shared.DTOs
{
    public class SubCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public bool? Status { get; set; }

        public Category Category { get; set; }
    }
}
