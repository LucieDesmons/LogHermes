namespace GestionStock.BL.Models
{
    public class ProduitModel
    {
        public int Id { get; set; }
        public string Nom { get; set; } = null!;

        public int Quantite { get; set; }

        public string Prix { get; set; }

        public byte[] Image { get; set; }

        public CategorieModel Categorie { get; set; }
    }
}
