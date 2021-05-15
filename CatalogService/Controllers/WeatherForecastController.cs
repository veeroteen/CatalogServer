using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogService.Models;
using CatalogService.StaticModels;

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
        public Order Post([FromBody] Order value)
        {
            return value;
        }





    }
}
