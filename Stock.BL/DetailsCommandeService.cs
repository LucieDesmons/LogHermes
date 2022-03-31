using Stock.DAL;

namespace Stock.BL
{
    public class DetailsCommandeService
    {
        private readonly DBLogHermesContext _context;

        public DetailsCommandeService(DBLogHermesContext context)
        {
            _context = context;
        }

        public List<Models.DetailsCommande> GetDetailsCmd()
        {
            return _context 
                .DetailsCommandes
                .Select(c => new Models.DetailsCommande
                {
                    Id = c.Id,
                    Quantite = c.Quantite,
                    Produit = new Models.Produit
                    {
                        Id = c.Produit.Id,
                        Nom = c.Produit.Nom,
                        Quantite = c.Produit.Quantite,
                        Prix = c.Produit.Prix,
                        Image = c.Produit.Image,
                        Categorie = new Models.Categorie
                        {
                            Id = c.Produit.Categorie.Id,
                            Nom = c.Produit.Categorie.Nom
                        }
                    }

                })
                .ToList(); 
        }
    }
}
