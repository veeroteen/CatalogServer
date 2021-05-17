using System;
using System.Collections.Generic;

#nullable disable

namespace CatalogService.Data.DataModel
{
    public partial class Country
    {
        public Country()
        {
            Towns = new HashSet<Town>();
        }

        public string Name { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Town> Towns { get; set; }
    }
}
