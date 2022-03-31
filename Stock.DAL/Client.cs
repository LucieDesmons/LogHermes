using System;
using System.Collections.Generic;

namespace Stock.DAL
{
    public partial class Client
    {

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string? Adresse { get; set; }
        public string? Ville { get; set; }
        public string? Pays { get; set; }
        public string? Telephone { get; set; }      
        public string Email { get; set; }

    }
}
