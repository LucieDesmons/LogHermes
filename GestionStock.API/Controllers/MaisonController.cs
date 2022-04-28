using Microsoft.AspNetCore.Mvc;
using GestionStock.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestionStock.API.Controllers
{
    [Route("api/maisons")]
    [ApiController]
    public class MaisonController : ControllerBase
    {
        private MaisonService _cs;
        public MaisonController(MaisonService cs)
        {
            _cs = cs; 
        }

        // GET: api/<MaisonController>
        [HttpGet]
        public List<BL.Models.MaisonModel> Get()
        {
            return _cs.GetMaisons();
        }

        // POST api/<CategoriesController>
        [HttpPost("{post}")]
        public string Post(BL.Models.MaisonModel maison)
        {
            try
            {
                _cs.CreateMaison(maison);
                return "Votre maison a bien été créée.";
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
