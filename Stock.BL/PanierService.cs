using GestionStock.DAL;
using GestionStock.BL.Models;

namespace GestionStock.BL
{
    public class PanierService
    {
        private readonly DBGestionStockContext _context;

        public PanierService(DBGestionStockContext context)
        {
            _context = context;
        }

        public string CreateLignePanier(int idProduit, int quantite, ClientModel connectedClient)
        {
            var retourMessage = "Produit déjà présent dans le panier. Quantité modifiée !";

            var panierContext = _context.Paniers;
            var clientContext = _context.Clients;

            var idClient = connectedClient?.Id;

            //récupération de la ligne de panier existante pour le client/produit
            var panierClientContext =
                panierContext
                .FirstOrDefault(w => w.IdClient == idClient
                                && w.IdProduit == idProduit);


            //Si la ligne de panier n'existe pas pour le produit/client on ajoute sinon on modifie juste la quantité
            if (panierClientContext == null)
            {
                panierClientContext = new Panier();
                panierClientContext.IdProduit = idProduit;
                panierClientContext.IdClient = idClient;
                panierContext.Add(panierClientContext);

                retourMessage = "Produit ajouté dans le panier !";
            }
            panierClientContext.Quantite = quantite;

            _context.SaveChanges();

            return retourMessage;
        }

        public int GetNbProduitPanier(int? idClient)
        {
            var nbProduit = 0;
            var panierContext = _context.Paniers;

            //Panier en mode connecté (idClient) ou déconnecté (idClient == null)
            /*if (idClient != null)
            {*/
                nbProduit = panierContext
                        .Where(w => w.IdClient == idClient)
                        .Count();
          /*  }*/

            return nbProduit;
        }


    }
}