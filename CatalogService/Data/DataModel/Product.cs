using System;
using System.Collections.Generic;

#nullable disable

namespace CatalogService.Data.DataModel
{
    public partial class Product
    {
        public Product()
        {
            SuplProducts = new HashSet<SuplProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Group { get; set; }
        public string Description { get; set; }
        public string Characteristics { get; set; }

        public virtual Group GroupNavigation { get; set; }
        public virtual ICollection<SuplProduct> SuplProducts { get; set; }
    }
}
