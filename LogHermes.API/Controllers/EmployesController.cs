using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/employes")]
    [ApiController]
    public class EmployesController : ControllerBase
    {
        // GET: api/<EmployesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployesController>/5
        [HttpPut("{id}")]

        public async Task<IActionResult> PutEmploye(int Id, Employe employe)
        {
            if (Id != employe.Id)
            {
                return BadRequest();
            }
            _es.Entry(employe).State = EntityState.Modified;
            try
            {
                await _es.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeExists(Id))
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
            // DELETE api/<EmployesController>/5
            [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmploye(int id)
        {
            var employe = await _es.Eployes.FindAsync(id);
            if (employe == null)
            {
                return NotFound();
            }
            _es.Employes.Remove(employe);
            await _es.SaveChangesAsync();

            return NoContent();
        }
    }
}
