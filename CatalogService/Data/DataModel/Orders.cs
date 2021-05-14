using System;
using System.Collections.Generic;

#nullable disable

namespace CatalogService.Data
{ 
    public partial class Orders
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DataReceave { get; set; }

        public virtual Client Client { get; set; }
    }
}
