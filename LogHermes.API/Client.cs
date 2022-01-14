using System;
using System.Collections.Generic;

namespace LogHermes.API
{
    public partial class Client
    {
        public Client()
        {
            Id1s = new HashSet<Employe>();
        }

        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Rue { get; set; }
        public int? CodePostal { get; set; }
        public string? Ville { get; set; }
        public string? Pays { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
        public string? NumSiret { get; set; }
        public string? NumTva { get; set; }
        public int Id1 { get; set; }

        public virtual CmdClient Id1Navigation { get; set; } = null!;

        public virtual ICollection<Employe> Id1s { get; set; }
    }
}
