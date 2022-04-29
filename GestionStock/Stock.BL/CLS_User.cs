using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Stock.BL
{
    internal class CLS_User
    {
        private dbStockContext db = new dbStockContext();
        private UTILISATEUR user;

        public bool AjoutUser(string Nom, string Mdp)
        {
            user = new UTILISATEUR();
            user.Nom_Utilisateur = Nom;
            user.Mot_de_passe = Mdp;
            if (db.UTILISATEUR.SingleOrDefault(s => s.Nom_Utilisateur == Nom) == null)
            {
                db.UTILISATEUR.Add(user);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        public void SuppUser(string nom)
        {
            user = new UTILISATEUR();
            user = db.UTILISATEUR.SingleOrDefault(s => s.Nom_Utilisateur == nom); //Vérifie si id user existe
            if (user != null) //user existe
            {
                db.UTILISATEUR.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
