using System;
using System.Collections.Generic;

namespace Stock.DAL
{
    public partial class Produit
    {

        public int Id { get; set; }
        public string Nom { get; set; } = null!;

        public string Quantite { get; set; }

        public string Prix { get; set; }

        public string Image { get; set; }

        public Categorie Categorie { get; set; }
    }
}

