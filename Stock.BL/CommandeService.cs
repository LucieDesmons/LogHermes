using Stock.DAL;

namespace Stock.BL
{
   public class CommandeService
    {
        private readonly DBLogHermesContext _context;

        public CommandeService(DBLogHermesContext context)
        {
            _context = context;
        }

        public List<Models.Commande> GetCmdClients()
        {
            return _context 
                .Commandes
                .Select(c => new Models.Commande
                {
                    Id = c.Id,
                    DateCmd = c.DateCmd,
                    Client = new Models.Client
                    {
                        Id = c.Client.Id,
                        Nom = c.Client.Nom,
                        Prenom = c.Client.Prenom,
                        Adresse = c.Client.Adresse,
                        Ville = c.Client.Ville,
                        Pays = c.Client.Pays,
                        Telephone = c.Client.Telephone,
                        Email = c.Client.Email
                    }
               
                })
                .ToList(); 
        }


        //fonctionne mais oblige à créer un nouveau client, gérer le cas où le client existe + gérer le cas où le client n'a pas de compte et ne veux pas en créer un
        public void CreateCommande(Models.Commande commande)
        {

            _context
                .Commandes
                .Add(new Commande
                {
                    Id = commande.Id,
                    DateCmd = commande.DateCmd,
                    Client = new Client
                    {
                        Id = commande.Client.Id,
                        Nom = commande.Client.Nom,
                        Prenom = commande.Client.Prenom,
                        Adresse = commande.Client.Adresse,
                        Ville = commande.Client.Ville,
                        Pays = commande.Client.Pays,
                        Telephone = commande.Client.Telephone,
                        Email = commande.Client.Email
                    }
                })
                .Context
                .SaveChanges();
        }

    }
}
