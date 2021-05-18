using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogService.Models;
using CatalogService.Data.Datamodel;
using System.Collections.ObjectModel;
using CatalogService.Data;

namespace CatalogService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        int p = 0;
        private readonly ILogger<WeatherForecastController> _logger;
        CatalogContext _context;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, CatalogContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Supplier> Get(string s)
        {
            var context = _context;
            context.Countries.Add(new Country() { Name = "Китай" });
            context.SaveChanges();

            return context.Suppliers;

        }

        [HttpPost]
        public ObservableCollection<ItemsInBasket> Post([FromBody] ObservableCollection<ItemsInBasket> request)
        {





            foreach (var s in request)
            {

                var n = new OrderDescriprion()
                {
                    Id = 1,
                    Count = s.count,
                    ItemId = Int32.Parse(s.Id)
                };

                _context.OrderDescriprions.Add(n);

            }
            _context.SaveChanges();
            return request;
        }





    }
}
