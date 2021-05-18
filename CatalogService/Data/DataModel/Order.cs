﻿using System;
using System.Collections.Generic;

#nullable disable

namespace CatalogService.Data.Datamodel
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DataReceave { get; set; }
        public string Status { get; set; }

        public virtual Client Client { get; set; }
    }
}
