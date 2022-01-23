using Stock.DAL;

namespace Stock.Models
{
    public class CmdFournisseur
    {
        public int Id { get; set; }
        public string? Libelle { get; set; }
        public DateTime? DateCmd { get; set; }
        public DateTime? DateLivraison { get; set; }
        public decimal? MontantCmd { get; set; }
        public string? ModePaiement { get; set; }
        public decimal? PrixAchatHt { get; set; }
        public decimal? Taxe { get; set; }
    }
}
