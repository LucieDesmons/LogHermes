using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/emplacement_stock")]
    [ApiController]
    public class EmplacementStockController : ControllerBase
    {
        // GET: api/<EmplacementStockController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmplacementStockController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmplacementStockController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmplacementStockController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmplacementStockController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
