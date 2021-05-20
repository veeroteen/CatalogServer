using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogService.Models
{
    public class ItemDetailDescription
    {
        public string DescriptionFull { get; set; }
        public List<Characteristics> Character { get; set; }
    }
}
