using GestionStock.DAL;
using GestionStock.BL.Models;
using System.Linq;

namespace GestionStock.BL
{
   public class CommandeService
    {
        private readonly DBGestionStockContext _context;

        public CommandeService(DBGestionStockContext context)
        {
            _context = context;
        }

        public List<CommandeModel> GetCmdClients()
        {
            return _context 
                .Commandes
                .Select(c => new CommandeModel
                {
                    Id = c.IdCommande,
                    DateCmd = c.DateCommande,
                    Client = new ClientModel
                    {
                        Id = c.Client.IdClient,
                        Nom = c.Client.NomClient,
                        Prenom = c.Client.PrenomClient,
                        Adresse = c.Client.AdresseClient,
                        Ville = c.Client.VilleClient,
                        Pays = c.Client.PaysClient,
                        Telephone = c.Client.TelephoneClient,
                        Email = c.Client.EmailClient
                    }
               
                })
                .ToList(); 
        }


        //fonctionne mais oblige à créer un nouveau client, gérer le cas où le client existe + gérer le cas où le client n'a pas de compte et ne veux pas en créer un
        public void CreateCommande(CommandeModel commande)
        {

            _context
                .Commandes
                .Add(new Commande
                {
                    IdCommande = commande.Id,
                    DateCommande = commande.DateCmd,
                    Client = new Client
                    {
                        IdClient = commande.Client.Id,
                        NomClient = commande.Client.Nom,
                        PrenomClient = commande.Client.Prenom,
                        AdresseClient = commande.Client.Adresse,
                        VilleClient = commande.Client.Ville,
                        PaysClient = commande.Client.Pays,
                        TelephoneClient = commande.Client.Telephone,
                        EmailClient = commande.Client.Email
                    }
                })
                .Context
                .SaveChanges();
        }

    }
}
