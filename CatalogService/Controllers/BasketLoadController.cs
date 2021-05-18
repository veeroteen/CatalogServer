using CatalogService.Data.Datamodel;
using CatalogService.Models;
using Microsoft.AspNetCore.Http;
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
    public class BasketLoadController : ControllerBase
    {

        private readonly ILogger<BasketLoadController> _logger;
        CatalogContext _context;
        public BasketLoadController(ILogger<BasketLoadController> logger, CatalogContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpPost]
        public ItemsInBasket Post([FromBody] string value)
        {

           //Проверка на существование необработанного заказа
            var orderid = (from i in _context.Orders
                          where (i.ClientId == Int32.Parse(value) && i.Status == null)
                          select i.Id).FirstOrDefault();

            var response = new ObservableCollection<ItemsInBasket>();

            var prod = from i in _context.OrderDescriprions
                         where (i.Id == orderid)
                         select i;

            foreach (var i in prod)
            {
                response.Add(new ItemsInBasket()
                    {
                    count = i.Count.Value,
                    Id = i.ItemId.ToString() 
                    }
                );
            }

            foreach (var i in response) 
            { 
            var buff = (from m in _context.Products
                       where (m.Id == Int32.Parse(i.Id))
                       select m).FirstOrDefault();
                i.Description = buff.Description;
                i.Text = buff.Name;
                i.Img = "ss.jpg";
            }
            return response.FirstOrDefault();


        }
    }
}
