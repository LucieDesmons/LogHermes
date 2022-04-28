using System;
using System.Collections.Generic;

namespace GestionStock.DAL
{
    public partial class DetailsCommande
    {
        public int IdDetail { get; set; }
        public int IdCommande { get; set; }
        public int IdProduit { get; set; }
        public string NomProduit { get; set; } = null!;
        public int Quantite { get; set; }
        public string Prix { get; set; } = null!;
        public string Remise { get; set; } = null!;
        public string Total { get; set; } = null!;

        public virtual Commande IdCommandeNavigation { get; set; } = null!;
        public virtual Produit IdProduitNavigation { get; set; } = null!;
    }
}
