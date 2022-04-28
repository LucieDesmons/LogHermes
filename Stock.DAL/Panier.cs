using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.DAL
{
    public class Panier
    {
        public int IdLignePanier { get; set; }
        public int IdProduit { get; set; }
        public int IdClient { get; set; }
        public int Quantite { get; set; }

        public virtual Client IdClientNavigation { get; set; } = null!;
    }
}
