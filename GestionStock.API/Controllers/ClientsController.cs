using Microsoft.AspNetCore.Mvc;
using GestionStock.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestionStock.API.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private ClientService _cs;
        public ClientsController(ClientService cs)
        {
            _cs = cs; //ClientService
        }

        // GET: api/<ClientsController>
        [HttpGet]
        public List<BL.Models.ClientModel> Get()
        {
            return _cs.GetClients();
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClientsController>
        [HttpPost("{post}")]
        public string Post(BL.Models.ClientModel client)
        {
            try
            {
                _cs.CreateClient(client);
                return "Votre client a bien été créé.";
            }
            catch (Exception ex)
            {
                return "La création a échoué.";
            }
        }

        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
