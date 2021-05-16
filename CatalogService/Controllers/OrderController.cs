using CatalogService.Data;
using CatalogService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;


namespace CatalogService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<int> Get(string s)
        {

            return Enumerable.Range(1, 1).Select(index => 1)
            .ToArray();

        }
        [HttpPost]
        public Models.Orders Post([FromBody] ObservableCollection<ItemsInBasket> request)
        {





            foreach (var s in request)
            {

                var n = new Data.OrderDescriprion()
                {
                    Id = 1,
                    Count = s.count,
                    ItemId = Int32.Parse(s.item.Id)
                };

                DBConnect.GetInstance().OrderDescriprions.Add(n);

            }
            DBConnect.GetInstance().SaveChanges();

            Models.Orders answ = new Models.Orders();

            return answ;



        }
    }
}
