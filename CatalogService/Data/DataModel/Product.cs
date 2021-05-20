using CatalogService.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace CatalogService.Data.Datamodel
{
    public partial class Product
    {
        public Product()
        {
            OrderDescriprions = new HashSet<OrderDescriprion>();
            SuplProducts = new HashSet<SuplProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Group { get; set; }
        public string Description { get; set; }
        public string Characteristics { get; set; }

        public virtual Group GroupNavigation { get; set; }
        public virtual ICollection<OrderDescriprion> OrderDescriprions { get; set; }
        public virtual ICollection<SuplProduct> SuplProducts { get; set; }


        public Item ConvertToItem() 
        {
            return (new Item()
            {
                Description = Description,
                Id = Id.ToString(),
                Img = "plug.jpg",
                Text = Name
            });

        }


    }
}
