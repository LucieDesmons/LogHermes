using GestionStock.DAL;
using GestionStock.BL.Models;

namespace GestionStock.BL
{
    public class ClientService
    {
        private readonly DBGestionStockContext _context;

        public ClientService(DBGestionStockContext context)
        {
            _context = context;
        }

        public List<ClientModel> GetClients()
        {
            return _context // DBLogHermesContext
                .Clients// DbSet<Client>
                .Select(c => new ClientModel
                {
                    Id = c.IdClient,
                    Nom = c.NomClient,
                    Prenom = c.PrenomClient,
                    Ville = c.VilleClient,
                    Pays = c.PaysClient,
                    Email = c.EmailClient,
                    Telephone = c.TelephoneClient,
                    Adresse = c.AdresseClient
                })
                .ToList(); //List<Client>
        }
    


        public void CreateClient(ClientModel client)
        {

            _context
                .Clients
                .Add(new Client
                {
                    IdClient = client.Id,
                    NomClient = client.Nom,
                    PrenomClient  = client.Prenom,
                    VilleClient  = client.Ville,
                    PaysClient  = client.Pays,
                    EmailClient  = client.Email,
                    TelephoneClient = client.Telephone,
                    AdresseClient  = client.Adresse
                })
                .Context
                .SaveChanges();
        }
    }
}