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


        //fonctionne mais oblige à créer un nouveau client, gérer le cas où le client existe + gérer le cas où le client n'a pas de compte et ne veux pas en créer un
        public void CreateCommande(CommandeModel commande)
        {

            _context
                .Commandes
                .Add(new Commande
                {
                    IdCommande = commande.Id,
                    DateCommande = commande.DateCmd,
                    IdClientNavigation = new Client
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
