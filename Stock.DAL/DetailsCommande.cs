using System;
using System.Collections.Generic;

namespace Stock.DAL
{
    public partial class DetailsCommande
    {

        public int Id { get; set; }

        public string Quantite { get; set; }

        public Produit Produit { get; set; }

    }
}