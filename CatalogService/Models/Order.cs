using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.Models
{
    public class Orders
    {
        public string ClientName { get; set; }
        public DateTime CreateDate { get; set; }

        public string IDOrder { get; set; }
    }
}
