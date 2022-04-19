using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Stock.BL
{
    internal class CLS_Client
    {
        private dbStockContext db= new dbStockContext();
        private CLIENT C;

        public bool Add_Client(string Nom, string Prenom, string Adresse, string Ville, string Pays, string Telephone, string Email)
        {
            C = new CLIENT();
            C.Nom_Client=Nom;
            C.Prenom_Client=Prenom;
            C.Adresse_Client=Adresse;
            C.Ville_Client=Ville;
            C.Pays_Client=Pays;
            C.Telephone_Client=Telephone;
            C.Email_Client=Email;
            //Vérifier si le nom et le prénom existe déjà dans la BDD
            if(db.CLIENT.SingleOrDefault(s =>s.Nom_Client == Nom)==null)
            {
                db.CLIENT.Add(C);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Modify_Client(int Id, string Nom, string Prenom, string Adresse, string Ville, string Pays, string Telephone, string Email)
        //Fonction pour modifier un client
        {
            C = new CLIENT();
            C = db.CLIENT.SingleOrDefault(s => s.Id_Client == Id); //Vérifie si id client existe
            if(C!=null) //client existe
            {
                C.Nom_Client = Nom;
                C.Prenom_Client = Prenom;
                C.Adresse_Client = Adresse;
                C.Ville_Client = Ville;
                C.Pays_Client = Pays;
                C.Telephone_Client = Telephone;
                C.Email_Client = Email;
                db.SaveChanges(); //sauvegerde des nouvelles informations
            }
        }
        //Fonction Supprimer fiche client
        public void Supp_Client(int Id)
        {
            C = new CLIENT();
            C = db.CLIENT.SingleOrDefault(s => s.Id_Client == Id); //Vérifie si id client existe
            if (C != null) //client existe
            {
                db.CLIENT.Remove(C);
                db.SaveChanges();
            }
        }

    }
}
