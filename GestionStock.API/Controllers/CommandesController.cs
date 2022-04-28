using Microsoft.AspNetCore.Mvc;
using GestionStock.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestionStock.API.Controllers
{
    [Route("api/commandes")]
    [ApiController]
    public class CommandesController : ControllerBase
    {
        private CommandeService _cs;
        public CommandesController(CommandeService cs)
        {
            _cs = cs; //CmdClientService
        }

        // GET: api/<CommandesController>
        [HttpGet]
        public List<BL.Models.CommandeModel> Get()
        {
            return _cs.GetCmdClients();
        }

        // GET api/<CommandesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CommandesController>
        [HttpPost("{post}")]
        public string Post(BL.Models.CommandeModel commande)
        {
            try
            {
                _cs.CreateCommande(commande);
                return "Votre commande a bien été créée.";
            }
            catch (Exception ex)
            {
                return "La création a échoué.";
            }
        }

        // PUT api/<CommandesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CommandesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
