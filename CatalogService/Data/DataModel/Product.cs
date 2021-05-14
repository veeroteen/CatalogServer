using System;
using System.Collections.Generic;

#nullable disable

namespace CatalogService.Data
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Group { get; set; }
        public string Description { get; set; }
        public string Characteristics { get; set; }

        public virtual Group GroupNavigation { get; set; }
    }
}
