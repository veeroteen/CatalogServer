using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogService.Data;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CatalogService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<int> Get(string s)
        {

            return Enumerable.Range(1, 1).Select(index => 1)
            .ToArray();

        }
        // POST api/<Login>
        [HttpPost]
        public string Post([FromBody] Models.Login value)
        {
            var instance = DBConnect.GetInstance();
            string ID = null;

            var quarry = from i in instance.Clients
                     where (i.Login == value.login && i.Password == value.password)
                     select i.Id;
            
            foreach (int id in quarry)
            {
                ID = id.ToString();
            }

            return ID;
        }


    }
}
