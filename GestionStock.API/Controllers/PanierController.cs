using GestionStock.BL;
using GestionStock.BL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionStock.API.Controllers
{
    [ApiController]
    public class PanierController : ControllerBase
    {
        private PanierService _cs;
        public PanierController(PanierService cs)
        {
            _cs = cs; //ClientService
        }

        // POST api/<ClientsController>
        [HttpPost("{post}")]
        public string CreateLignePanier(int id, int quantite, ClientModel connectedClient)
        {
            try
            {
                var message = _cs.CreateLignePanier(id, quantite, connectedClient);
                return message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }

}