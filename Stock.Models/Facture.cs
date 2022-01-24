using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Models
{
    class Facture
    {
        public int Id { get; set; }
        public string? Libelle { get; set; }
        public decimal? Montant { get; set; }
        public DateTime? DateFacture { get; set; }
        public int Id1 { get; set; }

        public virtual CmdClient Id1Navigation { get; set; } = null!;

        public virtual List<Employe> Id1s { get; set; }
    }
}
