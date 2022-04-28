using Microsoft.AspNetCore.Mvc;
using GestionStock.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestionStock.API.Controllers
{
    [Route("api/paniers")]
    [ApiController]
    public class PanierController : ControllerBase
    {
        private PanierService _cs;
        public PanierController(PanierService cs)
        {
            _cs = cs;
        }

        // GET: api/<PanierController>
        [HttpGet]
        public List<BL.Models.PanierModel> Get()
        {
            return _cs.GetPaniers();
        }

        // POST api/<CategoriesController>
        [HttpPost("{post}")]
        public string Post(BL.Models.PanierModel panier)
        {
            try
            {
                _cs.CreatePanier(panier);
                return "Votre panier a bien été créée.";
            }
            catch (Exception ex)
            {
                return "La création a échoué.";
            }


        }


        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
