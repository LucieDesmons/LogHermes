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

        public List<ProduitModel> GetProduit(int id)
        {

            return _context
                .Produits
                .Where(w => w.IdProduit == id)
                .Select(p => new ProduitModel
                {
                    Id = p.IdProduit,
                    Nom = p.NomProduit,
                    Annee = p.AnneeProduit,
                    Description = p.DescriptionProduit,
                    Quantite = p.QuantiteProduit,
                    Prix = p.PrixProduit,
                    PrixCarton = p.PrixCartonProduit,
                    Image = p.ImageProduit,
                    Categorie = new CategorieModel
                    {
                        Id = p.IdCategorieNavigation.IdCategorie,
                        Nom = p.IdCategorieNavigation.NomCategorie
                    }
                })
                .ToList();
        }

        public List<ProduitModel> GetProduits()
        {
            return _context 
                .Produits
                .Select(p => new ProduitModel
                {
                    Id = p.IdProduit,
                    Nom = p.NomProduit,
                    Annee = p.AnneeProduit,
                    Description = p.DescriptionProduit,
                    Quantite = p.QuantiteProduit,
                    Prix = p.PrixProduit,
                    PrixCarton = p.PrixCartonProduit,
                    Image = p.ImageProduit,
                    Categorie = new CategorieModel
                    {
                        Id = p.IdCategorieNavigation.IdCategorie,
                        Nom = p.IdCategorieNavigation.NomCategorie
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
                    AnneeProduit = produit.Annee,
                    DescriptionProduit = produit.Description,
                    QuantiteProduit = produit.Quantite,
                    PrixProduit = produit.Prix,
                    PrixCartonProduit = produit.PrixCarton,
                    ImageProduit = produit.Image,
                    IdCategorieNavigation = new Categorie
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
