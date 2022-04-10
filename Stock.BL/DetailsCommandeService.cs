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

        public void CreateDetailsCommande(Models.DetailsCommande details)
        {

            _context
                .DetailsCommandes
                .Add(new DetailsCommande
                {
                    Id = details.Id,
                    Quantite = details.Quantite,
                    Produit = new Produit
                    {
                        Id = details.Produit.Id,
                        Nom = details.Produit.Nom,
                        Quantite = details.Produit.Quantite,
                        Prix = details.Produit.Prix,
                        Image = details.Produit.Image,
                        Categorie = new Categorie
                        {
                            Id = details.Produit.Categorie.Id,
                            Nom = details.Produit.Categorie.Nom
                        }
                    }
                })
                .Context
                .SaveChanges();
        }

    }
}
