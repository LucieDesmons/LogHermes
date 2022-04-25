using GestionStock.DAL;
using GestionStock.BL.Models;
using System.Linq;

namespace GestionStock.BL
{
    public class DetailsCommandeService
    {
        private readonly DBGestionStockContext _context;

        public DetailsCommandeService(DBGestionStockContext context)
        {
            _context = context;
        }

        public List<DetailsCommandeModel> GetDetailsCmd()
        {
            return _context
                .DetailsCommandes
                .Select(c => new DetailsCommandeModel
                {
                    Id = c.IdDetail,
                    Quantite = c.Quantite,
                    Prix = c.Prix,
                    Remise = c.Remise,
                    Total = c.Total,
                    Produit = new ProduitModel
                    {
                        Id = c.IdProduitNavigation.IdProduit,
                        Nom = c.IdProduitNavigation.NomProduit,
                        Quantite = c.IdProduitNavigation.QuantiteProduit,
                        Prix = c.IdProduitNavigation.PrixProduit,
                        Image = c.IdProduitNavigation.ImageProduit,
                        Categorie = new CategorieModel
                        {
                            Id = c.IdProduitNavigation.IdCategorieNavigation.IdCategorie,
                            Nom = c.IdProduitNavigation.IdCategorieNavigation.NomCategorie
                        }
                    },
                    Commande = new CommandeModel
                    {
                        Id = c.IdCommandeNavigation.IdCommande,
                        DateCmd = c.IdCommandeNavigation.DateCommande,
                        TotalHT = c.IdCommandeNavigation.TotalHt,
                        TVA = c.IdCommandeNavigation.Tva,
                        TotalTTC = c.IdCommandeNavigation.TotalTtc,
                        Client = new ClientModel
                        {
                            Id = c.IdCommandeNavigation.IdClientNavigation.IdClient,
                            Nom = c.IdCommandeNavigation.IdClientNavigation.NomClient,
                            Prenom = c.IdCommandeNavigation.IdClientNavigation.PrenomClient,
                            Adresse = c.IdCommandeNavigation.IdClientNavigation.AdresseClient,
                            Telephone = c.IdCommandeNavigation.IdClientNavigation.TelephoneClient,
                            Pays = c.IdCommandeNavigation.IdClientNavigation.PaysClient,
                            Ville = c.IdCommandeNavigation.IdClientNavigation.VilleClient,
                            Email = c.IdCommandeNavigation.IdClientNavigation.EmailClient
                        }
                    }
                })
                .ToList();
        }

        public void CreateDetailsCommande(DetailsCommandeModel details)
        {

            _context
                .DetailsCommandes
                .Add(new DetailsCommande
                {
                    IdDetail = details.Id,
                    Quantite = details.Quantite,
                    Prix = details.Prix,
                    Remise = details.Remise,
                    Total = details.Total,
                    IdProduitNavigation = new Produit
                    {
                        IdProduit = details.Produit.Id,
                        NomProduit = details.Produit.Nom,
                        QuantiteProduit = details.Produit.Quantite,
                        PrixProduit = details.Produit.Prix,
                        ImageProduit = details.Produit.Image,
                        IdCategorieNavigation = new Categorie
                        {
                            IdCategorie = details.Produit.Categorie.Id,
                            NomCategorie = details.Produit.Categorie.Nom
                        }
                    },
                    IdCommandeNavigation = new Commande
                    {
                        IdCommande = details.Commande.Id,
                        DateCommande = details.Commande.DateCmd,
                        TotalHt = details.Commande.TotalHT,
                        Tva = details.Commande.TVA,
                        TotalTtc = details.Commande.TotalTTC,
                        IdClientNavigation = new Client
                        {
                            IdClient = details.Commande.Client.Id,
                            NomClient = details.Commande.Client.Nom,
                            PrenomClient = details.Commande.Client.Prenom,
                            AdresseClient = details.Commande.Client.Adresse,
                            TelephoneClient = details.Commande.Client.Telephone,
                            PaysClient = details.Commande.Client.Pays,
                            VilleClient = details.Commande.Client.Ville,
                            EmailClient = details.Commande.Client.Email
                        }
                    }
                })

                .Context
                .SaveChanges();
        }

    }
}
