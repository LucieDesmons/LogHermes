using Microsoft.AspNetCore.Mvc;
using GestionStock.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestionStock.API.Controllers
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
        public List<BL.Models.ProduitModel> Get()
        {
            return _ps.GetProduits();
        }

        // GET api/<produits>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        // POST api/<ProduitsController>
        [HttpPost("{post}")]
        public string Post(BL.Models.ProduitModel produit)
        {
            try
            {
                _ps.CreateProduit(produit);
                return "Votre produit a bien été créé.";
            }
            catch (Exception ex)
            {
                return "La création a échoué.";
            }
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
