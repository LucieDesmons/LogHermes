using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Models
{
    class Receptionner
    {
        public int Id { get; set; }
        public int Id1 { get; set; }
        public int? EntreeStock { get; set; }
        public decimal? PrixAchat { get; set; }

        public virtual CmdFournisseur Id1Navigation { get; set; } = null!;
        public virtual Article IdNavigation { get; set; } = null!;
    }
}
