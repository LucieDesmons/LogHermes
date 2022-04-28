using System;
using System.Collections.Generic;

namespace GestionStock.DAL
{
    public partial class Produit
    {
        public int IdProduit { get; set; }

        public int IdCategorie { get; set; }
        public int IdMaison { get; set; }
        public string NomProduit { get; set; } = null!;        
        public string AnneeProduit { get; set; } = null!;
        public string DescriptionProduit { get; set; } = null!;
        public int QuantiteProduit { get; set; }
        public decimal PrixProduit { get; set; }         
        public decimal PrixCartonProduit { get; set; } 
        public byte[] ImageProduit { get; set; } = null!;

        public virtual Categorie IdCategorieNavigation { get; set; } = null!;     
        public virtual Maison IdMaisonNavigation { get; set; } = null!;
    }
}
