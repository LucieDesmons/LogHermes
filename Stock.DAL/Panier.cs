using System;
using System.Collections.Generic;

namespace GestionStock.DAL
{
    public partial class Panier
    {
        public int IdLignePanier { get; set; }

        public int IdProduit { get; set; }
        public int? IdClient { get; set; }
        public int Quantite { get; set; }

        public virtual Client IdClientNavigation { get; set; } = null!;

        public virtual Produit IdProduitNavigation { get; set; } = null!;
    }
}