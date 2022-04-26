using GestionStock.DAL;
using GestionStock.BL;
using Microsoft.AspNetCore.Mvc;
using GestionStock.API.Controllers;
using GestionStock.BL.Models;

namespace SiteWeb.ViewComponents
{

    public class ProduitListViewComponent : ViewComponent
    {
        private readonly DBGestionStockContext _context;

        public ProduitListViewComponent(DBGestionStockContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var serviceProduit = new ProduitService(_context);
            var produitController = new ProduitsController(serviceProduit);
            List<ProduitModel> model = produitController.Get();

            return await Task.FromResult((IViewComponentResult)View("ProduitListCard", model));
        }
    }
}