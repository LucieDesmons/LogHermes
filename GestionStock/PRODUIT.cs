//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionStock
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUIT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUIT()
        {
            this.Details_Commande = new HashSet<Details_Commande>();
        }
    
        public int Id_Produit { get; set; }
        public string Nom_Produit { get; set; }
        public int Quantite_Produit { get; set; }
        public Nullable<decimal> Prix_Unitaire { get; set; }
        public Nullable<decimal> Prix_Carton { get; set; }
        public byte[] Image_Produit { get; set; }
        public string Description_Produit { get; set; }
        public Nullable<decimal> Année { get; set; }
        public int Id_Categorie { get; set; }
    
        public virtual CATEGORIE CATEGORIE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Details_Commande> Details_Commande { get; set; }
    }
}
