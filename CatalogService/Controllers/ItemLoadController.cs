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
    public class ItemLoadController : ControllerBase
    {
        CatalogContext _context;
        public ItemLoadController(ILogger<BasketController> logger, CatalogContext context)
        {
                _context = context;
        }



        [HttpPost]
        public ObservableCollection<Item> Post([FromBody] int[] couter)
        {
            ObservableCollection<Item> request = new ObservableCollection<Item>();

            var prod = from i in _context.Products
                       select i;

            for (int i = couter[0] - 1; i < couter[1] - 1; i++)
            {
                if (prod.AsEnumerable().ElementAtOrDefault(i) != null)
                {
                    var buff = prod.AsEnumerable().ElementAtOrDefault(i);
                    request.Add(new Item()
                    {
                        Description = buff.Description,
                        Id = buff.Id.ToString(),
                        Img = "plug.jpg",
                        Text = buff.Name
                    });


                }
            }

            return request;
        }





    }
}
