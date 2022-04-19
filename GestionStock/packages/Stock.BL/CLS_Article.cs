using System;
using System.Linq;

namespace Stock.Stock.BL
{
    internal class CLS_Article
    {
        private DbStockContext db = new DbStockContext();
        private Article article; //table article

        //Appel des données
        public bool Ajouter_Article(string nom, string Description, string Cepage, int Annee, decimal note, decimal prix, int Quantité, int Catégorie)
        {
            article = new Article();
            article.Nom = nom;
            article.Description = Description;
            article.Cepage = Cepage;
            article.Annee = Annee;
            article.Note = note;
            article.Prix_Produit = prix;
            article.Quantité_dispo = Quantité;
            article.Id_Categorie = Catégorie;

            if (db.Article.SingleOrDefault(x => x.Nom == nom && x.Cepage == Cepage && x.Annee == Annee) == null)
            {
                db.Article.Add(article); // ajoute dans la bdd
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
