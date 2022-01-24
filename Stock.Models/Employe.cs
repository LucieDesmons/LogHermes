using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Models
{
    class Employe
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Role { get; set; }

        public virtual Utilisateur Utilisateur { get; set; } = null!;

        public virtual List<EmplacementStock> Id1s { get; set; }
        public virtual List<CmdFournisseur> Id1sNavigation { get; set; }
        public virtual List<Fournisseur> Ids { get; set; }
        public virtual List<Article> Ids1 { get; set; }
        public virtual List<Client> Ids2 { get; set; }
        public virtual List<Facture> IdsNavigation { get; set; }
    }
}
