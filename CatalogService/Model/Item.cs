﻿using System;
using System.Collections.Generic;
using System.Text;




namespace CatalogService.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }

        public Item() 
        {
            Id = "ss";
            Text = "fad";
            Description = "sd";
            Img = "sag";
        }

    }
}
