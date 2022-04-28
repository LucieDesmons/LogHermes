using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock.Stock.PL
{
    public partial class FRM_AjoutClt : Form
    {
        private UserControl usclient;

        public FRM_AjoutClt(UserControl userC)
        {
            InitializeComponent();

            usclient = userC;
        }



        string testobligatoire()
        {
            if (textNom.Text == "" || textNom.Text == "Nom de client")
            {
                return "Entrer le nom de client";
            }
            if (textMail.Text == "")
            {
                try
                {
                    new MailAddress(textMail.Text);
                }
                catch (Exception e)
                {
                    return "Email Invalide";
                }
            }
            return null;
        }


        private void textTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57) //code asci des n°{
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        public int IDselect;
        private void btnValidClt_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (lblFicheClt.Text == "Fiche Client")
            {
                BL.CLS_Client clclient = new BL.CLS_Client();
                if (clclient.Add_Client(textNom.Text, textPrenom.Text, textAdresse.Text, textVille.Text, textPays.Text, textTel.Text, textMail.Text) == true)
                {
                    MessageBox.Show("Client crée", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //affiche le client deans le user
                    (usclient as USR_Client).ActualiseDataGrid();

                }
                else
                {
                    MessageBox.Show("Client déjà crée", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //si lblFicheClt = modification client
            {
                BL.CLS_Client clclient = new BL.CLS_Client();

                DialogResult R = MessageBox.Show("Confirmez la modification ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    clclient.Modify_Client(IDselect, textNom.Text, textPrenom.Text, textAdresse.Text, textVille.Text, textPays.Text, textTel.Text, textMail.Text);
                    (usclient as USR_Client).ActualiseDataGrid();
                    //actualise le datagrid
                    MessageBox.Show("Client modifié","Modification", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Modification annulée","Modification", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            textNom.Text = "Nom client"; textNom.ForeColor = Color.Silver;
            textPrenom.Text = "Prénom client"; textPrenom.ForeColor = Color.Silver;
            textAdresse.Text = "Adresse client"; textAdresse.ForeColor = Color.Silver;
            textTel.Text = "Téléphone Client"; textTel.ForeColor = Color.Silver;
            textVille.Text = "Ville client"; textVille.ForeColor = Color.Silver;
            textMail.Text = "Mail"; textMail.ForeColor = Color.Silver;
            textPays.Text = "Pays"; textPays.ForeColor = Color.Silver;
        }

        private void textNom_Enter(object sender, EventArgs e)
        {
            if(textNom.Text == "Nom de Client")
            {
                textNom.Text = "";
                textNom.ForeColor = Color.Black;
            }
        }
    }
}



