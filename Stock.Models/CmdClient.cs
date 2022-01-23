namespace Stock.Models
{
   public class CmdClient
    {
        public int Id { get; set; }
        public DateTime? DateCmd { get; set; }
        public string? Libelle { get; set; }
        public DateTime? DateLivraison { get; set; }
        public decimal? MontantCmd { get; set; }
        public string? Etat { get; set; }
        public string? LieuLivraison { get; set; }
        public string? ModePaiement { get; set; }
        public string? Devise { get; set; }
    }
}
