namespace GestionStock.BL.Models
{
    public class ProduitModel
    {
        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Annee { get; set; } = null!;
        public string Maison { get; set; } = null!;
        public string Description { get; set; } = null!;

        public int Quantite { get; set; }

        public decimal Prix { get; set; }
        public decimal PrixCarton { get; set; }

        public string Image { get; set; }

        public CategorieModel Categorie { get; set; }
    }
}
