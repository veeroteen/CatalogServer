using System;
using System.Collections.Generic;

#nullable disable

namespace CatalogService.Data
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? ItemId { get; set; }
        public int? Count { get; set; }

        public virtual Orders IdNavigation { get; set; }
        public virtual Product Item { get; set; }
    }
}
