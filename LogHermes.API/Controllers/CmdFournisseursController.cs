using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/cmd_fournisseurs")]
    [ApiController]
    public class CmdFournisseursController : ControllerBase
    {
        // GET: api/<CmdFournisseursController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CmdFournisseursController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CmdFournisseursController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CmdFournisseursController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCmdFournisseur(int Id, CmdFournisseur cmdFournisseur)
        {
            if (Id != cmdFournisseur.Id)
            {
                return BadRequest();
            }
            _fs.Entry(article).State = EntityState.Modified;
            try
            {
                await _fs.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CmdFournisseurExists(Id))
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

            // DELETE api/<CmdFournisseursController>/5
            [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCmdFournisseur(int id)
        {
            var cmdFournisseur = await _fs.CmdFournisseurs.FindAsync(id);
            if (cmdFournisseur == null)
            {
                return NotFound();
            }
            _fs.CmdFournisseurs.Remove(cmdFournisseur);
            await _fs.SaveChangesAsync();

            return NoContent();
        }
    }
}
