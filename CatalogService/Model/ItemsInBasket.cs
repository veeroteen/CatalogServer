﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogService.Models
{
    public class ItemsInBasket
    {
        public int Count { get; set; }
        public Item item { get; set; }
        public ItemsInBasket() 
        {
            Count = 0;
        }


    }
}
