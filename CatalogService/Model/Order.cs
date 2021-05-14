﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.Models
{
    public class Order
    {
        public string ClientName { get; set; }
        public ItemsInBasket [] Items { get; set; }
    }
}
