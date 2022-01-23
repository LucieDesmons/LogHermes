using Stock.DAL;

namespace Stock.BL
{
    public class ArticleService
    {
        private readonly DBLogHermesContext _context;

        public ArticleService(DBLogHermesContext context)
        {
            _context = context;
        }

        public List<Models.Article> GetArticles()
        {
            return _context // DBLogHermesContext
                .Articles// DbSet<Article>
                .Select(a => new Models.Article
                {
                    Id = a.Id,
                    Nom = a.Nom,
                    Description = a.Description,
                    Image = a.Image,
                    Note = a.Note,
                    Cepage = a.Cepage,
                    Annee = a.Annee,
                    Prix = a.Prix,
                    Taxe = a.Taxe,
                    Quantite = a.Quantite
                })
                .ToList(); //List<Article>
        }
    }
}