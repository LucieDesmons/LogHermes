using System;
using System.Collections.Generic;

namespace GestionStock.DAL
{
    public partial class Produit
    {
        public int IdProduit { get; set; }

        public int IdCategorie { get; set; }
        public string NomProduit { get; set; } = null!;
        public int QuantiteProduit { get; set; }
        public string PrixProduit { get; set; } = null!;
        public byte[] ImageProduit { get; set; } = null!;

        public virtual Categorie Categorie { get; set; } = null!;
    }
}
