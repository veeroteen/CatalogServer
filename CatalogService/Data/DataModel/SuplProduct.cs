using System;
using System.Collections.Generic;

#nullable disable

namespace CatalogService.Data.DataModel
{
    public partial class SuplProduct
    {
        public int Idsupplier { get; set; }
        public int Idproduct { get; set; }

        public virtual Product IdproductNavigation { get; set; }
        public virtual Supplier IdsupplierNavigation { get; set; }
    }
}
