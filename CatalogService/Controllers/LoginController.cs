using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogService.Data;
using Microsoft.Extensions.Logging;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CatalogService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        CatalogContext _context;
        public LoginController(ILogger<LoginController> logger, CatalogContext context)
        {
            _logger = logger;
            _context = context;
        }

        // POST api/<Login>
        [HttpPost]
        public string Post([FromBody] Models.Login value)
        {
            string ID = null;

            var quarry = from i in _context.Clients
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
