using GestionStock.DAL;
using GestionStock.BL.Models;

namespace GestionStock.BL
{
    public class CategorieService
    {
        private readonly DBGestionStockContext _context;

        public CategorieService(DBGestionStockContext context)
        {
            _context = context;
        }

        public List<CategorieModel> GetCategories()
        {
            return _context // DBGestionStockContext
                .Categories// DbSet<Categorie>
                .Select(c => new CategorieModel
                {
                    Id = c.IdCategorie,
                    Nom = c.NomCategorie,                    
                })
                .ToList(); //List<Categorie>
        }

        public void CreateCategorie(CategorieModel categorie)
        {

            _context 
                .Categories
                .Add(new Categorie
                {
                    IdCategorie = categorie.Id,
                    NomCategorie = categorie.Nom,
                })
                .Context
                .SaveChanges();
        }
    }
}