﻿using Microsoft.AspNetCore.Mvc;
using Stock.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHermes.API.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private CategorieService _cs;
        public CategoriesController(CategorieService cs)
        {
            _cs = cs; //CategorieService
        }

        // GET: api/<CategoriesController>
        [HttpGet]
        public List<Stock.Models.Categorie> Get()
        {
            return _cs.GetCategories();
        }

        // POST api/<CategoriesController>
        [HttpPost("{post}")]
        public string Post(Stock.Models.Categorie categorie)
        {
            try
            {
                _cs.CreateCategorie(categorie);
                return "Votre catégorie a bien été créée.";
            }
            catch (Exception ex)
            {
                return "La création a échoué.";
            }
            

        }
    

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
