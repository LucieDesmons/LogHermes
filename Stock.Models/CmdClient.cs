using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Models
{
    class CmdClient
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

        public virtual List<Client> Clients { get; set; }
        public virtual List<Correspondre> Correspondres { get; set; }
        public virtual List<Facture> Factures { get; set; }
    }
}
