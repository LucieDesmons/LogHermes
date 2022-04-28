namespace GestionStock.BL.Models
{
    public class ProduitModel
    {
        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Annee { get; set; } = null!;
        public string Description { get; set; } = null!;

        public int Quantite { get; set; }

        public decimal Prix { get; set; }
        public decimal PrixCarton { get; set; }

        public byte[] Image { get; set; }
        public string srcImage
        {
            get
            {
                //convertion de l'image au format binaire en format base64 pour pouvoir l'utiliser dans le html.
                var ImageToB64 = Convert.ToBase64String(this.Image);
                return (ImageToB64 != null && ImageToB64 != String.Empty ? "data:image/jpeg; base64," + ImageToB64 : "");
            }

        }

        public CategorieModel Categorie { get; set; }   
        public MaisonModel Maison { get; set; }
    }
}
