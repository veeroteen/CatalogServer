using CatalogService.Models;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogService.Data;
using Microsoft.Extensions.Logging;
using CatalogService.Data.Datamodel;
namespace CatalogService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BasketController : ControllerBase
    {

        private readonly ILogger<BasketController> _logger;
        CatalogContext _context;
        public BasketController(ILogger<BasketController> logger, CatalogContext context)
        {
            _logger = logger;
            _context = context;
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
        public void Post([FromBody] Models.Orders quest)
        {

            var quarry = (from m in _context.Orders
                     where m.ClientId == Int32.Parse(quest.ClientID) && m.Status == null
                     select m.Id).FirstOrDefault();

            if (quarry == 0) {

                _context.Orders.Add(new Data.Datamodel.Order
                {
                    ClientId = Int32.Parse(quest.ClientID),
                    DateCreate = DateTime.Now,
                    Status = null
                });
                _context.SaveChanges();
                quarry = (from m in _context.Orders
                              where m.ClientId == Int32.Parse(quest.ClientID) && m.Status == null
                              select m.Id).FirstOrDefault();
            }
           

            var o = (from m in _context.OrderDescriprions
                     where m.ItemId == Int32.Parse(quest.IDProduct) && m.Id== quarry
                     select m).FirstOrDefault();
            if (o == null)
            {
                _context.OrderDescriprions.Add(new OrderDescriprion
                {
                    Id = quarry,
                    Count = 1,
                    ItemId = Int32.Parse(quest.IDProduct)
                });
                _context.SaveChanges();

            }
            else
            {
                o.Count++;
                _context.SaveChanges();
            }
            












        }
    }
}
