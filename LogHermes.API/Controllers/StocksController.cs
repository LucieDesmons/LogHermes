using Microsoft.AspNetCore.Mvc;
using Stock.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/stocks")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private StockService _ss;
        public StocksController(StockService ss)
        {
            _ss = ss; //StockService
        }

        // GET: api/<StocksController>
        [HttpGet]
        public List<Stock.Models.Stocks> Get()
        {
            return _ss.GetStocks();
        }

        // GET api/<StocksController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StocksController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StocksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StocksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
