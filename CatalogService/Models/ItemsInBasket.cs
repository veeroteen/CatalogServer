using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogService.Models
{
    public class ItemsInBasket : Item
    {
        public int count { get; set; }
        public ItemsInBasket() 
        {
            count = 0;
        }


    }
}
