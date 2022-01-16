using System;
using System.Collections.Generic;

namespace Stock.DAL
{
    public partial class EmplacementStock
    {
        public EmplacementStock()
        {
            Ids = new HashSet<Article>();
            IdsNavigation = new HashSet<Employe>();
        }

        public int Id { get; set; }
        public int? NumRang { get; set; }
        public int? NumCasier { get; set; }

        public virtual ICollection<Article> Ids { get; set; }
        public virtual ICollection<Employe> IdsNavigation { get; set; }
    }
}
