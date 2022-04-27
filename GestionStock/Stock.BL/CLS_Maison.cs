using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Stock.BL
{
    internal class CLS_Maison
    {
        private dbStockContext db = new dbStockContext();
        private MAISON mais;

        public bool AjoutMais(string NomMais)
        {
            mais = new MAISON();
            mais.Nom_Maison = NomMais;
            if (db.MAISON.SingleOrDefault(s => s.Nom_Maison == NomMais) == null)
            {
                db.MAISON.Add(mais);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        public void Supp_Mais(int Id)
        {
            mais = new MAISON();
            mais = db.MAISON.SingleOrDefault(s => s.ID_MAISON == Id); //Vérifie si id categorie existe
            if (mais != null) //categorie existe
            {
                db.MAISON.Remove(mais);
                db.SaveChanges();
            }
        }
    }
}
