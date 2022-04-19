using System.Linq;

namespace Stock.Stock.BL
{
    class Connexion
    {
        public bool ConnexionValide(DbStockContext db, string Nom, string MotdePasse)

        {
            //constructeur
            Utilisateur u = new Utilisateur();
            u.NomUtilisateur = Nom;
            u.Mot_de_Passe = MotdePasse;
            if (db.Utilisateur.SingleOrDefault(s => s.NomUtilisateur == Nom && s.Mot_de_Passe == MotdePasse)!=null)
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
