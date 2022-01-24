using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/factures")]
    [ApiController]
    public class FacturesController : ControllerBase
    {
        private FactureService _fs;
        public FacturesController(FactureService fs)
        {
            _fs = fs;  
        }
        // GET: api/<FacturesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FacturesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FacturesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FacturesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFacture(int Id, Facture facture)
        {
            if (Id != facture.Id)
            {
                return BadRequest();
            }
            _fs.Entry(facture).State = EntityState.Modified;
            try
            {
                await _fs.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FactureExists(Id))
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
            // DELETE api/<FacturesController>/5
            [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFacture(int id)
        {
            var facture = await _fs.Factures.FindAsync(id);
            if (facture == null)
            {
                return NotFound();
            }
            _fs.Factures.Remove(facture);
            await _fs.SaveChangesAsync();

            return NoContent();
        }
    }
}
