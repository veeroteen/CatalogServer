using CatalogService.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private CatalogContext _context;
        public RegisterController(ILogger<RegisterController> logger, CatalogContext context) 
        {
            _context = context;
            
        }

        [HttpPost]
        public string Post([FromBody] Models.Register value)
        {
            string ID = null;

            _context.Clients.Add(new Client()
            {
                Id = 2,
                Login = value.Login,
                Password = value.Password,
                SecondName = value.SecondName,
                Name = value.Name,
                FatherName = value.FatherName,
                MobilePhone = value.MobilePhone
            });
            _context.SaveChanges();
            var quarry = from i in _context.Clients
                         where (i.Login == value.Login && i.Password == value.Password)
                         select i.Id;

            foreach (int id in quarry)
            {
                ID = id.ToString();
            }

            return ID;
        }


    }
}
