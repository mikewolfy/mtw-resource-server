using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ResourceServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        private QuotesService _svc;

        public QuotesController(QuotesService service)
        {
            _svc = service;
        }

        // GET: api/<QuotesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _svc.GetQuotes();
        }

        // GET api/<QuotesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return _svc.GetQuotes()[id];
        }

        // POST api/<QuotesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<QuotesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QuotesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
