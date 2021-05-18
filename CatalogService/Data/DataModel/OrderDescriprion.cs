using System;
using System.Collections.Generic;

#nullable disable

namespace CatalogService.Data.Datamodel
{
    public partial class OrderDescriprion
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int? Count { get; set; }

        public virtual Order IdNavigation { get; set; }
        public virtual Product Item { get; set; }
    }
}
