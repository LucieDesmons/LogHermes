using System;
using System.Windows.Forms;

namespace GestionStock.Stock.PL
{
    public partial class FRM_Authentification : Form
    {
        private dbStockContext db;
        Stock.BL.Connexion C = new Stock.BL.Connexion();
        public FRM_Authentification()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        string testIdentification()
        {
            if (textIdentifiant.Text == "" || textIdentifiant.Text == "Nom Utilisateur")
            {
                return "Entrer nom d'utilisateur";
            }
            if (textMotPasse.Text == "")
            {
                return "Entrer mot de passe";
            }
            return null;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void chkAffiche_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAffiche.Checked == true)
                textMotPasse.UseSystemPasswordChar = false;
            else
                textMotPasse.UseSystemPasswordChar = true;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

            if (testIdentification() == null)
            {
                if (C.ConnexionValide(db, textIdentifiant.Text, textMotPasse.Text) == true)
                {
                    MessageBox.Show("Bienvenu", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    FRM_Accueil f = new FRM_Accueil();
                    f.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Echec de connexion", "connexion", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    lblMessageErreur.Visible = true;
                }
            }


        }
    }
}
