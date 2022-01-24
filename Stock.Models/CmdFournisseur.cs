using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Models
{
    class CmdFournisseur
    {
        public int Id { get; set; }
        public string? Libelle { get; set; }
        public DateTime? DateCmd { get; set; }
        public DateTime? DateLivraison { get; set; }
        public decimal? MontantCmd { get; set; }
        public string? ModePaiement { get; set; }
        public decimal? PrixAchatHt { get; set; }
        public decimal? Taxe { get; set; }

        public virtual List<Receptionner> Receptionners { get; set; }

        public virtual List<Fournisseur> Ids { get; set; }
        public virtual List<Employe> IdsNavigation { get; set; }
    }
}
