using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Models
{
    class EmplacemetnStock
    {
        public int Id { get; set; }
        public int? NumRang { get; set; }
        public int? NumCasier { get; set; }

        public virtual List<Article> Ids { get; set; }
        public virtual List<Employe> IdsNavigation { get; set; }
    }
}
