using Stock.DAL;

namespace Stock.BL
{
    public class ClientService
    {
        private readonly DBLogHermesContext _context;

        public ClientService(DBLogHermesContext context)
        {
            _context = context;
        }

        public List<Models.Client> GetClients()
        {
            return _context // DBLogHermesContext
                .Clients// DbSet<Client>
                .Select(c => new Models.Client
                {
                    Id = c.Id,
                    Nom = c.Nom,
                    Prenom = c.Prenom,
                    Ville = c.Ville,
                    Pays = c.Pays,
                    Email = c.Email,
                    Telephone = c.Telephone,
                    Adresse = c.Adresse
                })
                .ToList(); //List<Client>
        }
    


        public void CreateClient(Models.Client client)
        {

            _context
                .Clients
                .Add(new Client
                {
                    Id = client.Id,
                    Nom = client.Nom,
                    Prenom= client.Prenom,
                    Ville= client.Ville,
                    Pays= client.Pays,
                    Email= client.Email,
                    Telephone = client.Telephone,
                    Adresse= client.Adresse
                })
                .Context
                .SaveChanges();
        }
    }
}