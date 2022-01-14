using System;
using System.Collections.Generic;

namespace LogHermes.API
{
    public partial class Employe
    {
        public Employe()
        {
            Id1s = new HashSet<EmplacementStock>();
            Id1sNavigation = new HashSet<CmdFournisseur>();
            Ids = new HashSet<Fournisseur>();
            Ids1 = new HashSet<Article>();
            Ids2 = new HashSet<Client>();
            IdsNavigation = new HashSet<Facture>();
        }

        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Role { get; set; }

        public virtual Utilisateur Utilisateur { get; set; } = null!;

        public virtual ICollection<EmplacementStock> Id1s { get; set; }
        public virtual ICollection<CmdFournisseur> Id1sNavigation { get; set; }
        public virtual ICollection<Fournisseur> Ids { get; set; }
        public virtual ICollection<Article> Ids1 { get; set; }
        public virtual ICollection<Client> Ids2 { get; set; }
        public virtual ICollection<Facture> IdsNavigation { get; set; }
    }
}
