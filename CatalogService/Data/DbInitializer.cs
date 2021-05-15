using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CatalogContext context)
        {
            context.Database.EnsureCreated();

            var group = new Group[]
            {
                new Group{Id = 1, Name = "Свечи зажигания"},
                new Group{Id = 2, Name = "Ремни"},
                new Group{Id = 3, Name = "Лампы"},

            };
            foreach(var s in group)
            {
                context.Groups.Add(s);

            }
            int i = context.SaveChanges();
            var products = new Product[]
            {
                new Product{Id = 1, Name = "DENSO W20FPR-U", Group=1,Characteristics="Nickel",Description = "роизводитель DENSO обеспечивает надежность и качество производимой продукции."},


            };
            foreach (var s in products)
            {
                context.Products.Add(s);

            }

            i = context.SaveChanges();












        }




    }
}
