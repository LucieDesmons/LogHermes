using Microsoft.AspNetCore.Mvc;
using Stock.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/fournisseurs")]
    [ApiController]
    public class FournisseursController : ControllerBase
    {
        private FournisseurService _fs;
        public FournisseursController(FournisseurService fs)
        {
            _fs = fs; //FournisseurService
        }

        // GET: api/<FournisseursController>
        [HttpGet]
        public List<Stock.Models.Fournisseur> Get()
        {
            return _fs.GetFournisseurs();
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
