using System;
using System.Collections.Generic;

namespace GestionStock.DAL
{
    public partial class Utilisateur
    {
        public string NomUtilisateur { get; set; } = null!;
        public string MotDePasse { get; set; } = null!;
    }
}
