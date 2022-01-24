// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/utilisateurs")]
    [ApiController]
    public class UtilisateursController : ControllerBase
    {
        private UtilisateurService _us;
        public UtilisateursController(UtilisateurService us)
        {
            _us = us; //UtilisateurService
        }

        // GET: api/<UtilisateursController>
        [HttpGet]
        public List<Stock.Models.Utilisateur> Get()
        {
            return _us.GetUsers();
        }

        // GET api/<UtilisateursController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UtilisateursController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UtilisateursController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUtilisateur(int Id, Utilisateur utilisateur)
        {
            if (Id != utilisateur.Id)
            {
                return BadRequest();
            }
            _us.Entry(utilisateur).State = EntityState.Modified;
            try
            {
                await _us.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UtilisateurExists(Id))
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
        // DELETE api/<UtilisateursController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUtilisateur(int id)
        {
            var utilisateur = await _context.Utilisateurs.FindAsync(id);
            if (utilisateur == null)
            {
                return NotFound();
            }
            _us.Utilisateurs.Remove(utilisateur);
            await _us.SaveChangesAsync();

            return NoContent();
        }
    }
}
