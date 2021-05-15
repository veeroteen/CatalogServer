using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogService.Models
{
    public class ItemsInBasket
    {
        public int count { get; set; }
        public Item item { get; set; }
        public ItemsInBasket() 
        {
            count = 0;
        }


    }
}
