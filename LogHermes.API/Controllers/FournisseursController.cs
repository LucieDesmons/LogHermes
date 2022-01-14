using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/fournisseurs")]
    [ApiController]
    public class FournisseursController : ControllerBase
    {
        // GET: api/<FournisseursController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FournisseursController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FournisseursController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FournisseursController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FournisseursController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
