using CatalogService.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogService.Models;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using CatalogService.Data.Datamodel;

namespace CatalogService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemDetailController : ControllerBase
    {
        private readonly ILogger<ItemDetailController> _logger;
        CatalogContext _context;
        public ItemDetailController(ILogger<ItemDetailController> logger, CatalogContext context)
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
        // POST api/<Login>
        [HttpPost]
        public ItemDetail Post([FromBody] string ID)
        {
            ItemDetail request = new ItemDetail();
            


            var quarry = from i in _context.Products
                         where i.Id == Int32.Parse(ID)
                         select i;

            List<Characteristics> Ch = new List<Characteristics>()
            {
            new Characteristics()
            {
            Name = "Материал",
            Value = "Никель"
            }


            };

            var serdata = JsonConvert.SerializeObject(Ch);
            foreach (var id in quarry)
            {





                request.Detail = new ItemDetailDescription()
                {

                    DescriptionFull = id.Description,
                    Character = JsonConvert.DeserializeObject<List<Characteristics>>(serdata)
                };
                request.item = id.ConvertToItem();
                
            }
                
               
            

            return request;
        }







    }
}
