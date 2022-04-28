using System;
using System.Collections.Generic;

namespace GestionStock.DAL
{
    public partial class Client
    {
        public int IdClient { get; set; }
        public string NomClient { get; set; } = null!;
        public string PrenomClient { get; set; } = null!;
        public string AdresseClient { get; set; } = null!;
        public string TelephoneClient { get; set; } = null!;
        public string PaysClient { get; set; } = null!;
        public string VilleClient { get; set; } = null!;
        public string EmailClient { get; set; } = null!;

    }
}
