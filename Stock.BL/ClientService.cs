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
                    Rue = c.Rue,
                    CodePostal = c.CodePostal,
                    Ville = c.Ville,
                    Pays = c.Pays,
                    Email = c.Email,
                    Telephone = c.Telephone,
                    NumSiret = c.NumSiret,
                    NumTva = c.NumTva,
                    Id1 = c.Id1
                })
                .ToList(); //List<Client>
        }
    }
}