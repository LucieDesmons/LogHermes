using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Models
{
    class Fournisseur
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Rue { get; set; }
        public int? CodePostal { get; set; }
        public string? Ville { get; set; }
        public string? Pays { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
        public string? NumSiret { get; set; }
        public string? NumTva { get; set; }

        public virtual List<Employe> Id1s { get; set; }
        public virtual List<CmdFournisseur> Id1sNavigation { get; set; }
    }
}
