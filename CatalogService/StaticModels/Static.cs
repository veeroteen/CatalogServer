using CatalogService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.StaticModels
{
    public static class Static
    {
        public static int p = 1;
        public static Order order { get; set; } = new Order();
        
    }
}
