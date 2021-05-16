using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogService.Models;

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
        public IEnumerable<Supplier> Get(string s)
        {

            return DBConnect.GetInstance().Suppliers;

        }

        [HttpPost]
        public ObservableCollection<ItemsInBasket> Post([FromBody] ObservableCollection<ItemsInBasket> request)
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
            return request;
        }





    }
}
