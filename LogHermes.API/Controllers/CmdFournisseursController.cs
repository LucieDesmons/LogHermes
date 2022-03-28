using Microsoft.AspNetCore.Mvc;
using Stock.BL;
using Stock.DAL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/cmd_fournisseurs")]
    [ApiController]
    public class CmdFournisseursController : ControllerBase
    {
        private CmdFournisseurService _fs;
        public CmdFournisseursController(CmdFournisseurService fs)
        {
            _fs = fs; //CmdFournisseurService
        }

        // GET: api/<CmdFournisseursController>
        [HttpGet]
        public List<Stock.Models.CmdFournisseur> Get()
        {
            return _fs.GetCmdFournisseurs();
        }

        // GET api/<CmdFournisseursController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CmdFournisseursController>
        [HttpPost("{post}")]
        public void Post(Stock.Models.CmdFournisseur cmdFournisseur)
        {
            _fs.CreateCmdFournisseurs(cmdFournisseur);

        }

        // PUT api/<CmdFournisseursController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CmdFournisseursController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
