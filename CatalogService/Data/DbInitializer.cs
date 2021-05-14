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


            var countries = new Country[]
            {
                new Country{Id = 1, Name = "Россия"},
                new Country{Id = 2, Name = "США"},
                new Country{Id = 3, Name = "Япония"},

            };
            foreach(var s in countries)
            {
                context.Countries.Add(s);

            }
            var towns = new Town[]
            {
                new Town{Id = 1, Name = "Москва", Country = 1},
                new Town{Id = 2, Name = "Миннеаполис", Country = 2},
                new Town{Id = 3, Name = "Акита", Country = 3},

            };
            foreach (var s in towns)
            {
                context.Towns.Add(s);

            }
            var streets = new Street[]
            {
                new Street{Id = 1, Name = "Мосстройпуть", Town = 1},
                new Street{Id = 2, Name = "Спрус", Town = 2},
                new Street{Id = 3, Name = "Отемати", Town = 3},

            };
            foreach (var s in streets)
            {
                context.Streets.Add(s);

            }
            int i = context.SaveChanges();












        }




    }
}
