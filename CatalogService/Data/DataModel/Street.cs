using System;
using System.Collections.Generic;

#nullable disable

namespace CatalogService.Data.DataModel
{
    public partial class Street
    {
        public Street()
        {
            Clients = new HashSet<Client>();
            Suppliers = new HashSet<Supplier>();
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public int? Town { get; set; }

        public virtual Town TownNavigation { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
