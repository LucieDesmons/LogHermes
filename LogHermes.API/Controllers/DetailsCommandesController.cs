using Microsoft.AspNetCore.Mvc;
using Stock.BL;

namespace LogHermes.API.Controllers
{
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

        // POST api/<CmdClientsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CmdClientsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CmdClientsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
