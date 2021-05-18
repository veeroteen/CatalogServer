using System;
using System.Collections.Generic;

#nullable disable

namespace CatalogService.Data.Datamodel
{
    public partial class Supplier
    {
        public Supplier()
        {
            SuplProducts = new HashSet<SuplProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? Street { get; set; }

        public virtual Street StreetNavigation { get; set; }
        public virtual ICollection<SuplProduct> SuplProducts { get; set; }
    }
}
