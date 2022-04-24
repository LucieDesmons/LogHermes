using System;
using System.Collections.Generic;

namespace GestionStock.DAL
{
    public partial class Commande
    {
        public int IdCommande { get; set; }
        public DateTime DateCommande { get; set; }
        public int IdClient { get; set; }
        public string? TotalHt { get; set; }
        public string? Tva { get; set; }
        public string? TotalTtc { get; set; }

        public virtual Client Client { get; set; } = null!;
    }
}
