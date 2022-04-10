using Microsoft.AspNetCore.Mvc;
using Stock.BL;

namespace LogHermes.API.Controllers
{
    [Route("api/details_commande")]
    [ApiController]
    public class DetailsCommandesController : Controller
    {
        private DetailsCommandeService _cs;
        public DetailsCommandesController(DetailsCommandeService cs)
        {
            _cs = cs; 
        }

        // GET: api/<details_commandes>
        [HttpGet]
        public List<Stock.Models.DetailsCommande> Get()
        {
            return _cs.GetDetailsCmd();
        }

        // GET api/<CmdClientsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DetailsCommandeController>
        [HttpPost("{post}")]
        public string Post(Stock.Models.DetailsCommande details)
        {
            try
            {
                _cs.CreateDetailsCommande(details);
                return "Vos détails de commande ont bien été créés.";
            }
            catch (Exception ex)
            {
                return "La création a échoué.";
            }


        }

        // PUT api/<DetailsCommandeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DetailsCommandeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
