using Microsoft.AspNetCore.Mvc;
using Stock.models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/articles")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        // GET: api/<ArticlesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ArticlesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ArticlesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ArticlesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticle(int Id, Article article)
        {
            if(Id != article.Id) 
            {
                return BadRequest();
            }
            _as.Entry(article).State = EntityState.Modified;
            try
            {
                await _as.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleExists(Id))
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

        // DELETE api/<ArticlesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticle(int id)
        {
            var article = await _as.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            _as.Articles.Remove(article);
            await _as.SaveChangesAsync();

            return NoContent();
        }
    }
}
}
