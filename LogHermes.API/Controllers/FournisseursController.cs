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
        public async Task<IActionResult> PutFournisseur(int Id, Fournisseur fournisseur)
        {
            if (Id != fournisseur.Id)
            {
                return BadRequest();
            }
            _fs.Entry(fournisseur).State = EntityState.Modified;
            try
            {
                await _fs.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FournisseurExists(Id))
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
            // DELETE api/<FournisseursController>/5
            [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFournisseur(int id)
        {
            var fournisseur = await _fs.Fournisseurs.FindAsync(id);
            if (fournisseur == null)
            {
                return NotFound();
            }
            _fs.Fournisseurs.Remove(fournisseur);
            await _fs.SaveChangesAsync();

            return NoContent();
        }
    }
}
