using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgilisaTest.Models;
using AgilisaTest.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgilisaTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test : ControllerBase
    {
        private readonly IMasterTestService _masterTestService;

        public Test(IMasterTestService masterTestService)
        {
            _masterTestService = masterTestService;
        }

        // GET: api/<Test>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var master = new MasterTest
            {
                Name = "Lego",
                Details = new List<DetailsTest>
                {
                     new DetailsTest
                     {
                         ListItem = "Test"
                     }
                }
            };

            _masterTestService.Add(master);
            _masterTestService.SaveChanges();

            return new string[] { "value1", "value2" };

        }

        // GET api/<Test>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Test>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Test>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Test>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
