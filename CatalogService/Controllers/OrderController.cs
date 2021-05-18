using CatalogService.Data;
using CatalogService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        /*
        [HttpPost]
        public Models.Orders Post([FromBody] ObservableCollection<ItemsInBasket> request)
        {


            var OrdID = from i in _context.Orders
                         where (i.ClientId == value.login && i.Password == value.password)
                         select i.Id;

            foreach (int id in quarry)
            {
                ID = id.ToString();
            }






            foreach (var s in request)
            {
                
                var n = new Data.OrderDescriprion()
                {
                    Id = 1,
                    Count = s.count,
                    ItemId = Int32.Parse(s.item.Id)
                };

                _context.OrderDescriprions.Add(n);

            }
            _context.SaveChanges();

            Models.Orders answ = new Models.Orders();

            return answ;



        }
        */
    }
}
