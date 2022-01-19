using System;
using System.Collections.Generic;

namespace Stock.DAL
{
    public partial class Facture
    {
        public Facture()
        {
            Id1s = new HashSet<Employe>();
        }

        public int Id { get; set; }
        public string? Libelle { get; set; }
        public decimal? Montant { get; set; }
        public DateTime? DateFacture { get; set; }
        public int Id1 { get; set; }

        public virtual CmdClient Id1Navigation { get; set; } = null!;

        public virtual ICollection<Employe> Id1s { get; set; }
    }
}
