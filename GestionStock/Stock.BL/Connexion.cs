using System.Linq;

namespace GestionStock.Stock.BL
{
    class Connexion
    {
        public bool ConnexionValide(dbStockContext db, string Nom, string MotdePasse)

        {
            //constructeur
            UTILISATEUR u = new UTILISATEUR();
            u.Nom_Utilisateur = Nom;
            u.Mot_de_passe = MotdePasse;
            if (db.UTILISATEUR.SingleOrDefault(s => s.Nom_Utilisateur == Nom && s.Mot_de_passe == MotdePasse) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
