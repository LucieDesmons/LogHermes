namespace GestionStock.BL.Models
{
    public class DetailsCommandeModel
    {
        public int Id { get; set; }

        public int Quantite { get; set; }
        public string Prix { get; set; }
        public string Remise { get; set; }
        public string Total { get; set; }


        public ProduitModel Produit { get; set; }
        public CommandeModel Commande { get; set; }
    }
}
