﻿namespace GestionStock.BL.Models
{
    public class ClientModel
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
