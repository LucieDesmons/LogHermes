using Microsoft.AspNetCore.Mvc;
using Stock.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/cmd_clients")]
    [ApiController]
    public class ProduitsController : ControllerBase
    {
        private ProduitService _ps;
        public ProduitsController(ProduitService ps)
        {
            _ps = ps; //CmdClientService
        }

        // GET: api/<produits>
        [HttpGet]
        public List<Stock.Models.Produit> Get()
        {
            return _ps.GetProduits();
        }

        // GET api/<produits>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<produits>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<produits>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<produits>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
