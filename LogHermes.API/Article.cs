using System;
using System.Collections.Generic;

namespace LogHermes.API
{
    public partial class Article
    {
        public Article()
        {
            Correspondres = new HashSet<Correspondre>();
            Receptionners = new HashSet<Receptionner>();
            Id1s = new HashSet<EmplacementStock>();
            Id1sNavigation = new HashSet<Employe>();
        }

        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Description { get; set; }
        public byte[]? Image { get; set; }
        public decimal? Note { get; set; }
        public string? Cepage { get; set; }
        public DateTime? Annee { get; set; }
        public decimal Prix { get; set; }
        public decimal? Taxe { get; set; }
        public int? Quantite { get; set; }
        public int Id1 { get; set; }

        public virtual Categorie Id1Navigation { get; set; } = null!;
        public virtual ICollection<Correspondre> Correspondres { get; set; }
        public virtual ICollection<Receptionner> Receptionners { get; set; }

        public virtual ICollection<EmplacementStock> Id1s { get; set; }
        public virtual ICollection<Employe> Id1sNavigation { get; set; }
    }
}
