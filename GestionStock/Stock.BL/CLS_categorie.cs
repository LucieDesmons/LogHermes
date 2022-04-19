using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Stock.BL
{
    internal class CLS_categorie
    {
        private dbStockContext db = new dbStockContext();
        private CATEGORIE cat;

        public bool AjoutCat(string NomCat)
        {
            cat = new CATEGORIE();
            cat.Nom_Categorie = NomCat;
            if(db.CATEGORIE.SingleOrDefault(s => s.Nom_Categorie == NomCat) == null)
            {
                db.CATEGORIE.Add(cat);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        public void Supp_Cat(int Id)
        {
            cat = new CATEGORIE();
            cat = db.CATEGORIE.SingleOrDefault(s => s.Id_Categorie == Id); //Vérifie si id categorie existe
            if (cat != null) //categorie existe
            {
                db.CATEGORIE.Remove(cat);
                db.SaveChanges();
            }
        }
    }
}
