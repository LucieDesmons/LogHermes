using Microsoft.AspNetCore.Mvc;
using GestionStock.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestionStock.API.Controllers
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
        public List<BL.Models.UtilisateurModel> Get()
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
        [HttpPost("{post}")]
        public string Post(BL.Models.UtilisateurModel utilisateur)
        {
            try
            {
                _us.CreateUtilisateur(utilisateur);
                return "Votre utilisateur a bien été créé.";
            }
            catch (Exception ex)
            {
                return "La création a échoué.";
            }
        }

        // PUT api/<UtilisateursController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UtilisateursController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
