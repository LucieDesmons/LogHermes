using System;
using System.Collections.Generic;

namespace LogHermes.API
{
    public partial class Fournisseur
    {
        public Fournisseur()
        {
            Id1s = new HashSet<Employe>();
            Id1sNavigation = new HashSet<CmdFournisseur>();
        }

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

        public virtual ICollection<Employe> Id1s { get; set; }
        public virtual ICollection<CmdFournisseur> Id1sNavigation { get; set; }
    }
}
