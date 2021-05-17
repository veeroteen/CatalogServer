using System;
using System.Collections.Generic;

#nullable disable

namespace CatalogService.Data.DataModel
{
    public partial class Town
    {
        public Town()
        {
            Streets = new HashSet<Street>();
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public int? Country { get; set; }

        public virtual Country CountryNavigation { get; set; }
        public virtual ICollection<Street> Streets { get; set; }
    }
}
