using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GestionStock.BL;
using GestionStock.BL.Models;
using GestionStock.DAL;
using GestionStock.API.Controllers;
using SiteWeb.Models;

namespace SiteWeb.Controllers
{
    public class GestionStockAPIController : Controller
    {

        private readonly DBGestionStockContext _context;

        public GestionStockAPIController(DBGestionStockContext context)
        {
            _context = context;
        }

        [HttpPost()]
        public JsonResult getOneProduit(int id)
        {
            var serviceProduit = new ProduitService(_context);
            var produitController = new ProduitsController(serviceProduit);
            List<ProduitModel> model = produitController.GetOneProduit(id);

            return this.Json(new JsonResultModel()
            {
                Success = true,
                Data = model
            });
        }
    }
}
