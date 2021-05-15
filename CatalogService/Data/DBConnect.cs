using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.Data
{
    public class DBConnect
    {
        public static CatalogContext instance;
        public static CatalogContext GetInstance()
        {
            return instance;
        }
        public static void SetInstance(CatalogContext context) 
        {
            instance = context;
        }
        public DBConnect() { }
    }
}
