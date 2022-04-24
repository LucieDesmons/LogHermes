using GestionStock.DAL;
using GestionStock.BL.Models;
using System.Linq;

namespace GestionStock.BL
{
    public class ProduitService
    {
        private readonly DBGestionStockContext _context;

        public ProduitService(DBGestionStockContext context)
        {
            _context = context;
        }

        public List<ProduitModel> GetProduits()
        {
            return _context 
                .Produits
                .Select(p => new ProduitModel
                {
                    Id = p.IdProduit,
                    Nom = p.NomProduit,
                    Quantite = p.QuantiteProduit,
                    Prix = p.PrixProduit,
                    Image = p.ImageProduit,
                    Categorie = new CategorieModel
                    {
                        Id = p.Categorie.IdCategorie,
                        Nom = p.Categorie.NomCategorie
                    }
                })
                .ToList(); 
        }

        public void CreateProduit(ProduitModel produit)
        {

            _context
                .Produits
                .Add(new Produit
                {

                    IdProduit = produit.Id,
                    NomProduit = produit.Nom,
                    QuantiteProduit = produit.Quantite,
                    PrixProduit = produit.Prix,
                    ImageProduit = produit.Image,
                    Categorie = new Categorie
                    {
                        IdCategorie = produit.Categorie.Id,
                        NomCategorie = produit.Categorie.Nom
                    }
                })
                .Context
                .SaveChanges();
        }
    }
}
