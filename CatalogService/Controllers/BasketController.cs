using CatalogService.Models;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogService.Data;



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
        /*
        [HttpGet]
        public IEnumerable<OrderDescriprion> Get(string s)
        {

            return Enumerable.Range(1, 1).Select(index => new Models.Orders
            {
                ClientName = s

            
            }).ToArray();
        }
        */
        [HttpPost]
        public void Post([FromBody] ItemBuy quest)
        {
            var instance = DBConnect.GetInstance();

            instance.Orders.Add(new Data.Orders
            {
                ClientId = Int32.Parse(quest.IDUser),
                Id = 1,
                DateCreate = DateTime.Now
            });
            instance.SaveChanges();



        }
    }
}
