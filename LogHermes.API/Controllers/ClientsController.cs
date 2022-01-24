using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        // GET: api/<ClientsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClientsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClient(int Id, Client client)
        {
            if (Id != client.Id)
            {
                return BadRequest();
            }
            _cs.Entry(client).State = EntityState.Modified;
            try
            {
                await _cs.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

            // DELETE api/<ClientsController>/5
            [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var client = await _cs.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            _cs.Clients.Remove(client);
            await _cs.SaveChangesAsync();

            return NoContent();
        }
    }
}
