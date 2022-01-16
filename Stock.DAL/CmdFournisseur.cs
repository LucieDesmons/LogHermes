using System;
using System.Collections.Generic;

namespace Stock.DAL
{
    public partial class CmdFournisseur
    {
        public CmdFournisseur()
        {
            Receptionners = new HashSet<Receptionner>();
            Ids = new HashSet<Fournisseur>();
            IdsNavigation = new HashSet<Employe>();
        }

        public int Id { get; set; }
        public string? Libelle { get; set; }
        public DateTime? DateCmd { get; set; }
        public DateTime? DateLivraison { get; set; }
        public decimal? MontantCmd { get; set; }
        public string? ModePaiement { get; set; }
        public decimal? PrixAchatHt { get; set; }
        public decimal? Taxe { get; set; }

        public virtual ICollection<Receptionner> Receptionners { get; set; }

        public virtual ICollection<Fournisseur> Ids { get; set; }
        public virtual ICollection<Employe> IdsNavigation { get; set; }
    }
}
