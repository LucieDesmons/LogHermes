using System;
using System.Windows.Forms;

namespace Stock.Stock.PL
{
    public partial class FRM_Authentification : Form
    {
        private DbStockContext db;
        //classe connexion
        Stock.BL.Connexion C = new Stock.BL.Connexion();
        public FRM_Authentification()
        {
            InitializeComponent();
            db = new DbStockContext(); //nouvelle objet
        }

        string testIdentification()
        {
            if (txtIdentifiant.Text == "" || txtIdentifiant.Text == "Nom Utilisateur")
            {
                return "Enter votre nom d'utilisateur";
            }
            if (txtMotPasse.Text == null)
            {
                return "Entrer votre mot de passe";
            }
            return null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkBoxAffiche_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxAffiche.Checked)
                txtMotPasse.UseSystemPasswordChar = false;
            else
                txtMotPasse.UseSystemPasswordChar = true;

        }


        private void btnValider_Click(object sender, EventArgs e) //Fonction lors du clic valider
        {
            if (testIdentification() == null) 
            { 
                if(C.ConnexionValide(db, txtIdentifiant.Text, txtMotPasse.Text) == true)
                {
                    MessageBox.Show("Connexion réussie", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    FRM_Accueil f = new FRM_Accueil();
                    //FRM_Load l = new FRM_Load();
                    f.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Echec de connexion", "Connexion", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    lblMessageErreur.Visible = true;
                }
            }
        }
    }
}
