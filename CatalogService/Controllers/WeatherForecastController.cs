using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogService.Models;
using CatalogService.StaticModels;
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ItemsInBasket> Get(string s)
        {
            
                return Enumerable.Range(1, 1).Select(index => new ItemsInBasket
                {
                    count = 1


                })
                .ToArray();
            
        }

        [HttpPost]
        public ObservableCollection<ItemsInBasket> Post([FromBody] ObservableCollection<ItemsInBasket> request)
        {





            foreach (var s in request)
            {

                var n = new Data.Order()
                {
                    Id = 1,
                    Count = s.count,
                    ItemId = Int32.Parse(s.item.Id)
                };

                DBConnect.GetInstance().Order.Add(n);

            }
            DBConnect.GetInstance().SaveChanges();
            return request;
        }





    }
}
