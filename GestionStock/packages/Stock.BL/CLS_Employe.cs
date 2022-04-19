using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Stock.BL
{
    internal class CLS_Employe
    {
        private DbStockContext db = new DbStockContext();
        private Employe employe;
        public bool Ajouter_Employe(string nom, string prénom, string role)
        {
            employe = new Employe();
            employe.Nom = nom;
            employe.Prénom = prénom;
            employe.Rôle = role;

            if (db.Employe.SingleOrDefault(e => e.Nom == nom && e.Prénom == prénom)) == null) 
            {
                db.Employe.Add(employe); // ajoute dans la bdd
                db.SaveChanges();// enregistre dans la bdd
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
