using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock.Stock.PL
{
    public partial class FRM_User : Form
    {
        public FRM_User()
        {
            InitializeComponent();
        }

        private UserControl userUs;
        public FRM_User(UserControl userUser)
        {
            InitializeComponent();
            userUs = userUser;
        }


        private void textNomUser_Enter(object sender, EventArgs e)
        {
            if (textNomUser.Text == "Nom")
            {
                textNomUser.Text = "";
                textNomUser.ForeColor = Color.Black;
            }
        }



        private void btnValidUs_Click(object sender, EventArgs e)
        {
            BL.CLS_User cLS_Categorie = new BL.CLS_User();

            if (textNomUser.Text == "Nom" || textNomUser.Text == "")
            {
                MessageBox.Show("Entrer nom", "Ajout user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cLS_Categorie.AjoutUser(textNomUser.Text, textMdpUser.Text) == false)
                {
                    MessageBox.Show("Nom déjà existant", "Ajout nom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Nom créé", "Ajout nom", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (userUs as USR_User).remplirdata();
                }

            }
        }

        private void btnQuitUs_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

