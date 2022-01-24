using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Models
{
    public class Article
    {
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
        public virtual List<Correspondre> Correspondres { get; set; }
        public virtual List<Receptionner> Receptionners { get; set; }

        public virtual List<EmplacementStock> Id1s { get; set; }
        public virtual List<Employe> Id1sNavigation { get; set; }
    }
}
