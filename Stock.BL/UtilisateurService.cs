using Stock.DAL;

namespace Stock.BL
{
    public class UtilisateurService
    {
        private readonly DBLogHermesContext _context;

        public UtilisateurService(DBLogHermesContext context)
        {
            _context = context;
        }

         public List<Models.Utilisateur> GetUsers()
        {
            return _context // DBLogHermesContext
                .Utilisateurs// DbSet<Utilisateur>
                .Select(u => new Models.Utilisateur
                {
                    Id = u.Id,
                    MotDePasse = u.MotDePasse,
                    NomUtilisateur = u.NomUtilisateur
                })
                .ToList(); //List<Utilisateur>
        }

        public void CreateUtilisateur(Models.Utilisateur utilisateur)
        {

            _context
                .Utilisateurs
                .Add(new Utilisateur
                {
                    Id = utilisateur.Id,
                    MotDePasse = utilisateur.MotDePasse,
                    NomUtilisateur = utilisateur.NomUtilisateur
                })
                .Context
                .SaveChanges();
        }
    }
}