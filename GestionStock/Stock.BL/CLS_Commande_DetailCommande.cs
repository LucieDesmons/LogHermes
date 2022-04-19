using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Stock.BL
{
    internal class CLS_Commande_DetailCommande
    {
        private dbStockContext db = new dbStockContext();
        private COMMANDE clscmd;
        private Details_Commande clsDcmd;
        public int Id_Commande;
        //Sauvegarde de la commande
        public void Ajouter_Commande(DateTime DateC, int IdClient, string TotalHT, string TVA, string TotalTTC)
        {
            clscmd = new COMMANDE();
            clscmd.Date_Commande=DateC;
            clscmd.Id_Client=IdClient;
            clscmd.Total_HT=TotalHT;
            clscmd.TVA=TVA;
            clscmd.Total_TTC=TotalTTC;
            db.COMMANDE.Add(clscmd);
            db.SaveChanges();
            Id_Commande = clscmd.Id_Commande;
        }
        public void Ajouter_Detail(int IdProduit, string NomProduit,int Quantite, string Prix, string Remise, string Total)
        {
            clsDcmd = new Details_Commande();
            clsDcmd.Id_Commande = Id_Commande;
            clsDcmd.Id_Produit = IdProduit;
            clsDcmd.NomProduit = NomProduit;
            clsDcmd.Quantite = Quantite;
            clsDcmd.Prix = Prix;
            clsDcmd.Remise = Remise;
            clsDcmd.Total = Total;
            db.Details_Commande.Add(clsDcmd);
            db.SaveChanges();
        }
    }
}
