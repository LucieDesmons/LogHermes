using Stock.DAL;

namespace Stock.BL
{
    public class CategorieService
    {
        private readonly DBLogHermesContext _context;

        public CategorieService(DBLogHermesContext context)
        {
            _context = context;
        }

        public List<Models.Categorie> GetCategories()
        {
            return _context // DBLogHermesContext
                .Categories// DbSet<Categorie>
                .Select(c => new Models.Categorie
                {
                    Id = c.Id,
                    Nom = c.Nom,
                })
                .ToList(); //List<Categorie>
        }

        public void CreateCategorie(Models.Categorie categorie)
        {

            _context 
                .Categories
                .Add(new Categorie
                {
                    Id = categorie.Id,
                    Nom = categorie.Nom,
                })
                .Context
                .SaveChanges();
        }
    }
}