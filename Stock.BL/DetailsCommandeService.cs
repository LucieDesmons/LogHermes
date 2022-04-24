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
                        Id = c.Produit.IdProduit,
                        Nom = c.Produit.NomProduit,
                        Quantite = c.Produit.QuantiteProduit,
                        Prix = c.Produit.PrixProduit,
                        Image = c.Produit.ImageProduit,
                        Categorie = new CategorieModel
                        {
                            Id = c.Produit.Categorie.IdCategorie,
                            Nom = c.Produit.Categorie.NomCategorie
                        }
                    },
                    Commande = new CommandeModel
                    {
                        Id = c.Commande.IdCommande,
                        DateCmd = c.Commande.DateCommande,
                        TotalHT = c.Commande.TotalHt,
                        TVA = c.Commande.Tva,
                        TotalTTC = c.Commande.TotalTtc,
                        Client = new ClientModel
                        {
                            Id = c.Commande.Client.IdClient,
                            Nom = c.Commande.Client.NomClient,
                            Prenom = c.Commande.Client.PrenomClient,
                            Adresse = c.Commande.Client.AdresseClient,
                            Telephone = c.Commande.Client.TelephoneClient,
                            Pays = c.Commande.Client.PaysClient,
                            Ville = c.Commande.Client.VilleClient,
                            Email = c.Commande.Client.EmailClient
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
                    Produit = new Produit
                    {
                        IdProduit = details.Produit.Id,
                        NomProduit = details.Produit.Nom,
                        QuantiteProduit = details.Produit.Quantite,
                        PrixProduit = details.Produit.Prix,
                        ImageProduit = details.Produit.Image,
                        Categorie = new Categorie
                        {
                            IdCategorie = details.Produit.Categorie.Id,
                            NomCategorie = details.Produit.Categorie.Nom
                        }
                    },
                    Commande = new Commande
                    {
                        IdCommande = details.Commande.Id,
                        DateCommande = details.Commande.DateCmd,
                        TotalHt = details.Commande.TotalHT,
                        Tva = details.Commande.TVA,
                        TotalTtc = details.Commande.TotalTTC,
                        Client = new Client
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
