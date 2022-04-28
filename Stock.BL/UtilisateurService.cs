using GestionStock.DAL;
using GestionStock.BL.Models;
using System.Linq;


namespace GestionStock.BL
{
    public class UtilisateurService
    {
        private readonly DBGestionStockContext _context;

        public UtilisateurService(DBGestionStockContext context)
        {
            _context = context;
        }

         public List<UtilisateurModel> GetUsers()
        {
            return _context // DBLogHermesContext
                .Utilisateurs// DbSet<Utilisateur>
                .Select(u => new UtilisateurModel
                {
                    MotDePasse = u.MotDePasse,
                    NomUtilisateur = u.NomUtilisateur
                })
                .ToList(); //List<Utilisateur>
        }

        public void CreateUtilisateur(UtilisateurModel utilisateur)
        {

            _context
                .Utilisateurs
                .Add(new Utilisateur
                {
                    MotDePasse = utilisateur.MotDePasse,
                    NomUtilisateur = utilisateur.NomUtilisateur
                })
                .Context
                .SaveChanges();
        }
    }
}