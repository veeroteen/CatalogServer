using CatalogService.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogService.Models;
using Newtonsoft.Json;

namespace CatalogService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemDetailController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<int> Get(string s)
        {

            return Enumerable.Range(1, 1).Select(index => 1)
            .ToArray();

        }
        // POST api/<Login>
        [HttpPost]
        public ItemDetailDescription Post([FromBody] string ID)
        {
            ItemDetailDescription request = new ItemDetailDescription();
            var instance = DBConnect.GetInstance();


            var quarry = from i in instance.Products
                         where i.Id.ToString() == ID
                         select i;

            foreach (var id in quarry)
            {
                request.Char = JsonConvert.DeserializeObject<List<Characteristics>>(id.Characteristics);
                request.DescriptionFull = id.Description;
            
            }

            return request;
        }







    }
}
