using System;
using System.Collections.Generic;

#nullable disable

namespace CatalogService.Data
{
    public partial class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? Street { get; set; }

        public virtual Street StreetNavigation { get; set; }
    }
}
