﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/cmd_fournisseurs")]
    [ApiController]
    public class CmdFournisseursController : ControllerBase
    {
        // GET: api/<CmdFournisseursController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CmdFournisseursController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CmdFournisseursController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
