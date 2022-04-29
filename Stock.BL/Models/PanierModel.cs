using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.BL.Models
{
    public class PanierModel
    {
        public int IdLignePanier { get; set; }

        public int IdProduit { get; set; }
        public int? IdClient { get; set; }
        public int Quantite { get; set; }

        public virtual ClientModel IdClientNavigation { get; set; } = null!;

        public virtual ProduitModel IdProduitNavigation { get; set; } = null!;
    }
}
