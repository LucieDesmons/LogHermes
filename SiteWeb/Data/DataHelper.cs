using GestionStock.BL.Models;
using GestionStock.DAL;
using SiteWeb.Models;

namespace SiteWeb.Data
{
    public class DataHelper
    {

        public static ClientModel getConnectedClient(string emailClient, DBGestionStockContext context)
        {
            //récupération du client avec l'email (identifiant unique)
            var connectedClient = context
                .Clients
                .Where(w => w.EmailClient == emailClient)
                .Select(p => new ClientModel
                {
                    Id = p.IdClient,

                })
                .FirstOrDefault();

            return connectedClient;
        }

        /*public static List<PanierContentItemModel> getPanierContent(int? idClient, DBGestionStockContext context)
        {
            var panierContent = context
                .Paniers
                .Where(w => w.IdClient == idClient)
                .Select(p => new PanierContentItemModel
                {
                    IdClient = p.IdClient,
                    Id = p.IdProduit,
                    Quantite = p.Quantite,
                    Prix = p.IdProduitNavigation.PrixProduit,
                    Image = p.IdProduitNavigation.ImageProduit,

                })
                .ToList();

            return panierContent;
        }*/
    }
}