using System;
using System.Collections.Generic;

namespace LogHermes.API
{
    public partial class Utilisateur
    {
        public int Id { get; set; }
        public string? NomUtilisateur { get; set; }
        public string? MotDePasse { get; set; }
        public int Id1 { get; set; }

        public virtual Employe Id1Navigation { get; set; } = null!;
    }
}
