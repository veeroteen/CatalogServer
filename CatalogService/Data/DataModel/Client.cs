﻿using System;
using System.Collections.Generic;

#nullable disable

namespace CatalogService.Data
{
    public partial class Client
    {
        public Client()
        {
            Order1s = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int? Street { get; set; }
        public string MobilePhone { get; set; }
        public string SecondName { get; set; }
        public string FatherName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual Street StreetNavigation { get; set; }
        public virtual ICollection<Orders> Order1s { get; set; }
    }
}
