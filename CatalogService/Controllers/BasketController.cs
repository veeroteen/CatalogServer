using CatalogService.Models;
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


        public BasketController()
        {
        }


        [HttpPost]
        public Order Post([FromBody] Order order)
        {
#if DEBUG
            Console.WriteLine(order.ClientName);
#endif

            return order;
        }
    }
}
