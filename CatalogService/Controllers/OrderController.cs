using CatalogService.Data;
using CatalogService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CatalogService.Data.Datamodel;


namespace CatalogService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        CatalogContext _context;
        public OrderController(ILogger<OrderController> logger, CatalogContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<int> Get(string s)
        {

            return Enumerable.Range(1, 1).Select(index => 1)
            .ToArray();

        }
        
        [HttpPost]
        public void Post([FromBody] string request)
        {


            var k = (from m in _context.Orders
                     where m.ClientId == Int32.Parse(request) && m.Status == null
                     select m).FirstOrDefault();
            k.Status = "Pending";
            _context.SaveChanges();
        }
        
    }
}
