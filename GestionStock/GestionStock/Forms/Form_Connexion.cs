using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock.Forms
{
    public partial class Form_Connexion : Form
    {
        public Form_Connexion()
        {
            InitializeComponent();
        }
        //Vérification de la saisie des champs obligatoires

        string testobligatoire()
        {
            if(txtUser.Text == "" || txtUser.Text == "Nom Utilisateur")
            {
                return "Entrer votre nom";
            }
            if(txtMotPass.Text == "" || txtMotPass.Text == "Mot de passe")
            {
                return "Entrer votre mot de passe";
            }
            return null;
        }
        private void btnSortie_Click(object sender, EventArgs e)
        {
            //Fermer la fenêtre
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "Nom Utilisateur")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                txtUser.Text = "Nom Utilisateur";
                txtUser.ForeColor = Color.DarkGray;
            }
        }

        private void txtMotPass_Enter(object sender, EventArgs e)
        {
            if(txtMotPass.Text == "Mot de passe")
            {
                txtMotPass.Text = "";
                txtMotPass.ForeColor = Color.WhiteSmoke;
            }

        }

        private void txtMotPass_Leave(object sender, EventArgs e)
        {
            if(txtMotPass.Text == "")
            {
                txtMotPass.Text = "Mot de passe";
                txtMotPass.ForeColor = Color.DarkGray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            if(testobligatoire() == null)
            {
                MessageBox.Show("Code correct");
            }else
            {
                MessageBox.Show(testobligatoire(), "Code obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
