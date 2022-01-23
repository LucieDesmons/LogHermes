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
                    Nature = c.Nature
                })
                .ToList(); //List<Categorie>
        }
    }
}