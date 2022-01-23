using Microsoft.AspNetCore.Mvc;
using Stock.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/employes")]
    [ApiController]
    public class EmployesController : ControllerBase
    {
        private EmployeService _es;
        public EmployesController(EmployeService es)
        {
            _es = es; //EmployeService
        }

        // GET: api/<EmployesController>
        [HttpGet]
        public List<Stock.Models.Employe> Get()
        {
            return _es.GetEmployes();
        }


        // GET api/<EmployesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
