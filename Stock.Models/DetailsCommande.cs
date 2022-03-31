namespace Stock.Models
{
    public class DetailsCommande
    {
        public int Id { get; set; }

        public string Quantite { get; set; }

        public Produit Produit { get; set; }
    }
}
