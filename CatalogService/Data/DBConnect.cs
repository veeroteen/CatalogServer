using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogService.Data.Datamodel;

namespace CatalogService.Data
{
    public class DBConnect
    {
        public static CatalogContext instance;
        public static CatalogContext GetInstance()
        {
            return instance;
        }
        public static void SetInstance(IServiceProvider service) 
        {
            instance = service.GetRequiredService<CatalogContext>();
            instance.Database.EnsureCreated();
        }
        public DBConnect() { }





    }
}
