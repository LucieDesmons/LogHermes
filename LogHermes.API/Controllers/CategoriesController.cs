using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        // GET: api/<CategoriesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategorie(int Id, Categorie categorie)
        {
            if (Id != categorie.Id)
            {
                return BadRequest();
            }
            _cs.Entry(categorie).State = EntityState.Modified;
            try
            {
                await _cs.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategorieExists(Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

            // DELETE api/<CategoriesController>/5
            [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategorie(int id)
        {
            var categorie = await _cs.Categories.FindAsync(id);
            if (categorie == null)
            {
                return NotFound();
            }
            _cs.Categories.Remove(categorie);
            await _cs.SaveChangesAsync();

            return NoContent();
        }
    }
}
}
