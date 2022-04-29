using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GestionStock.BL;
using GestionStock.BL.Models;
using GestionStock.DAL;
using GestionStock.API.Controllers;
using SiteWeb.Models;
using SiteWeb.Data;
using Microsoft.AspNetCore.Identity;

namespace SiteWeb.Controllers
{
    public class GestionStockAPIController : Controller
    {

        private readonly DBGestionStockContext _context;

        private readonly UserManager<IdentityUser> _userManager;

        public GestionStockAPIController(DBGestionStockContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
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

        [HttpPost()]
        public JsonResult createLignePanier(int id, int quantite)
        {

            ClientModel connectedClient = DataHelper.getConnectedClient(getConnectedUser()?.Email, _context);

            var servicePanier = new PanierService(_context);
            var panierController = new PanierController(servicePanier);
            var lignePanierSuccess = panierController.CreateLignePanier(id, quantite, connectedClient);

            return this.Json(new JsonResultModel()
            {
                Success = true,
                ErrorMessage = lignePanierSuccess
            });
        }
        public IdentityUser getConnectedUser()
        {
            var result = HttpContext != null ? _userManager.GetUserAsync(HttpContext.User)?.Result : null;
            return result;
        }

        public JsonResult getnbProduitPanier()
        {
            var errorMessage = String.Empty;
            var nbProduit = 0;

            try
            {
                var servicePanier = new PanierService(_context);

                var connectedClient = DataHelper.getConnectedClient(getConnectedUser()?.Email, _context);
                nbProduit = servicePanier.GetNbProduitPanier(connectedClient?.Id);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            return this.Json(new JsonResultModel()
            {
                Success = errorMessage == String.Empty,
                ErrorMessage = errorMessage,
                Data = nbProduit
            });
        }
    }
}
