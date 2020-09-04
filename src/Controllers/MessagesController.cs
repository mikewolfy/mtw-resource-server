using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResourceServer.Models;
using ResourceServer.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ResourceServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private QuotesService _svc;

        public MessagesController(QuotesService svc)
        {
            _svc = svc;
        }

        // GET: api/<MessagesController>
        [HttpGet]
        public IEnumerable<Message> Get()
        {
            return _svc.GetQuotes().Select(q => new Message { Text = q });
        }

        // GET api/<MessagesController>/5
        [HttpGet("{id}")]
        public Message Get(int id)
        {
            return new Message { Text = _svc.GetQuotes()[id] };
        }

        // POST api/<MessagesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MessagesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MessagesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
