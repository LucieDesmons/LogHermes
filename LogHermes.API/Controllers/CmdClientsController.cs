using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/cmd_clients")]
    [ApiController]
    public class CmdClientsController : ControllerBase
    {
        // GET: api/<CmdClientsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CmdClientsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CmdClientsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CmdClientsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CmdClientsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
