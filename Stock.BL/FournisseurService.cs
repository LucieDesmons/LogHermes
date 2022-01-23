using Stock.DAL;

namespace Stock.BL
{
    public class FournisseurService
    {
        private readonly DBLogHermesContext _context;

        public FournisseurService(DBLogHermesContext context)
        {
            _context = context;
        }

        public List<Models.Fournisseur> GetFournisseurs()
        {
            return _context // DBLogHermesContext
                .Fournisseurs// DbSet<Fournisseur>
                .Select(f => new Models.Fournisseur
                {
                    Id = f.Id,
                    Nom = f.Nom,
                    Rue = f.Rue,
                    CodePostal = f.CodePostal,
                    Ville = f.Ville,
                    Pays = f.Pays,
                    Email = f.Email,
                    Telephone = f.Telephone,
                    NumSiret = f.NumSiret,
                    NumTva = f.NumTva
                })
                .ToList(); //List<Fournisseur>
        }
    }
}