﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Stock.BL
{
    internal class CLS_Article
    {
        private dbStockContext db = new dbStockContext();
        private PRODUIT PR;
        public bool Ajouter_Produit(string NomP, int Quantite, string PrixP, byte[] Image, int idcategorie)
        {
            PR = new PRODUIT();
            PR.Nom_Produit = NomP;
            PR.Quantite_Produit = Quantite;
            PR.Prix_Produit = PrixP;
            PR.Image_Produit = Image;
            PR.Id_Categorie = idcategorie;
            if (db.PRODUIT.SingleOrDefault(p => p.Nom_Produit == NomP) == null)
            {
                db.PRODUIT.Add(PR);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        //Modifier un article
        public void Modify_Produit(int IDP, string NomP, int Quantite, string PrixP, byte[] Image, int idcategorie)
        {
            PR = new PRODUIT();
            PR = db.PRODUIT.SingleOrDefault(p => p.Id_Produit == IDP); //Vérifie si id article existe
            if (PR != null) //Article existe
            {
                PR.Nom_Produit = NomP;
                PR.Quantite_Produit = Quantite;
                PR.Prix_Produit = PrixP;
                PR.Image_Produit = Image;
                PR.Id_Categorie = idcategorie;
                db.SaveChanges(); //sauvegerde des nouvelles informations
            }
        }
        //Fonction Supprimer fiche client
        public void Supp_Produit(int IDP)
        {
            PR = new PRODUIT();
            PR = db.PRODUIT.SingleOrDefault(p => p.Id_Produit == IDP); //Vérifie si id article existe
            if (PR != null) //Article existe
            {
                db.PRODUIT.Remove(PR);
                db.SaveChanges();
            }
        }
    }
}
