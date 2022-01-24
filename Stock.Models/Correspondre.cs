using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Models
{
    class Correspondre
    {
        public int Id { get; set; }
        public int Id1 { get; set; }
        public decimal? PrixVente { get; set; }
        public int? SortieStock { get; set; }

        public virtual CmdClient Id1Navigation { get; set; } = null!;
        public virtual Article IdNavigation { get; set; } = null!;
    }
}
