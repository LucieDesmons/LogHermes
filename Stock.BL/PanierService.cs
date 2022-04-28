using GestionStock.DAL;
using GestionStock.BL.Models;
using System.Linq;

namespace GestionStock.BL
{
    public class PanierService
    {
        private readonly DBGestionStockContext _context;

        public PanierService(DBGestionStockContext context)
        {
            _context = context;
        }

        public List<PanierModel> GetPaniers()
        {
            return _context
                .Paniers
                .Select(c => new PanierModel
                {
                    IdLignePanier = c.IdLignePanier,
                    IdProduit = c.IdProduit,
                    IdClient = c.IdClient,
                    Quantite = c.Quantite,
                    IdClientNavigation = new ClientModel
                    {

                        Id = c.IdClientNavigation.IdClient,
                        Nom = c.IdClientNavigation.NomClient,
                        Prenom = c.IdClientNavigation.PrenomClient,
                        Adresse = c.IdClientNavigation.AdresseClient,
                        Ville = c.IdClientNavigation.VilleClient,
                        Pays = c.IdClientNavigation.PaysClient,
                        Telephone = c.IdClientNavigation.TelephoneClient,
                        Email = c.IdClientNavigation.EmailClient

                    }


                })
                .ToList();
        }

        public void CreatePanier(PanierModel panier)
        {

            _context
                .Paniers
                .Add(new Panier
                {
                    IdLignePanier = panier.IdLignePanier,
                    IdProduit = panier.IdProduit,
                    IdClient = panier.IdClient,
                    Quantite = panier.Quantite,
                    IdClientNavigation = new Client
                    {
                        IdClient = panier.IdClientNavigation.Id,
                        NomClient = panier.IdClientNavigation.Nom,
                        PrenomClient = panier.IdClientNavigation.Prenom,
                        AdresseClient = panier.IdClientNavigation.Adresse,
                        VilleClient = panier.IdClientNavigation.Ville,
                        PaysClient = panier.IdClientNavigation.Pays,
                        TelephoneClient = panier.IdClientNavigation.Telephone,
                        EmailClient = panier.IdClientNavigation.Email
                    }
                })
                .Context
                .SaveChanges();
        }

    }
}

