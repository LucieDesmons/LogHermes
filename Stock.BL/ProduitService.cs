using Stock.DAL;

namespace Stock.BL
{
    public class ProduitService
    {
        private readonly DBLogHermesContext _context;

        public ProduitService(DBLogHermesContext context)
        {
            _context = context;
        }

        public List<Models.Produit> GetProduits()
        {
            return _context 
                .Produits
                .Select(p => new Models.Produit
                {
                    Id = p.Id,
                    Nom = p.Nom,
                    Quantite = p.Quantite,
                    Prix = p.Prix,
                    Image = p.Image,
                    Categorie = new Models.Categorie
                    {
                        Id = p.Categorie.Id,
                        Nom = p.Categorie.Nom
                    }
                })
                .ToList(); 
        }
    }
}
