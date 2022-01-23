using Microsoft.AspNetCore.Mvc;
using Stock.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/cmd_clients")]
    [ApiController]
    public class CmdClientsController : ControllerBase
    {
        private CmdClientService _cs;
        public CmdClientsController(CmdClientService cs)
        {
            _cs = cs; //UtilisateurService
        }

        // GET: api/<UtilisateursController>
        [HttpGet]
        public List<Stock.Models.CmdClient> Get()
        {
            return _cs.GetCmdClients();
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
