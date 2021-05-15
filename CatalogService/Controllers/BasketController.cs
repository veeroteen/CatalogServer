using CatalogService.Models;
using CatalogService.StaticModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BasketController : ControllerBase
    {
        string s = "gg";

        public BasketController()
        {
           
        }
        [HttpGet]
        public IEnumerable<Order> Get(string s)
        {

            return Enumerable.Range(1, 1).Select(index => new Order 
            {
                ClientName = Static.order.ClientName,
                Items = Static.order.Items
            
            }).ToArray();
        }
        [HttpPost]
        public Order Post([FromBody] Order request)
        {

            Static.order = request;
            return request;
        }
    }
}
