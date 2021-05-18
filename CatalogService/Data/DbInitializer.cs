using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogService.Data.Datamodel;
namespace CatalogService.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CatalogContext context)
        {
            





            int i = 0;
            
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
