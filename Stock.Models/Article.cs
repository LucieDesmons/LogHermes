namespace Stock.Models
{
   public class Article
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Description { get; set; }
        public byte[]? Image { get; set; }
        public decimal? Note { get; set; }
        public string? Cepage { get; set; }
        public DateTime? Annee { get; set; }
        public decimal Prix { get; set; }
        public decimal? Taxe { get; set; }
        public int? Quantite { get; set; }
    }
}
