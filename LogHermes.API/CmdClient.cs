using System;
using System.Collections.Generic;

namespace LogHermes.API
{
    public partial class CmdClient
    {
        public CmdClient()
        {
            Clients = new HashSet<Client>();
            Correspondres = new HashSet<Correspondre>();
            Factures = new HashSet<Facture>();
        }

        public int Id { get; set; }
        public DateTime? DateCmd { get; set; }
        public string? Libelle { get; set; }
        public DateTime? DateLivraison { get; set; }
        public decimal? MontantCmd { get; set; }
        public string? Etat { get; set; }
        public string? LieuLivraison { get; set; }
        public string? ModePaiement { get; set; }
        public string? Devise { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Correspondre> Correspondres { get; set; }
        public virtual ICollection<Facture> Factures { get; set; }
    }
}
