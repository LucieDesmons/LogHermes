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
    public partial class FRM_Maison : Form
    {
        private UserControl userMais;
        public FRM_Maison(UserControl userMaison)
        {
            InitializeComponent();
            userMais = userMaison;
        }
        private void btnQuitArt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textMais_Enter(object sender, EventArgs e)
        {
            if (textMais.Text == "Nouvelle catégorie")
            {
                textMais.Text = "";
                textMais.ForeColor = Color.Black;
            }
        }

        private void btnValidCat_Click_1(object sender, EventArgs e)
        {
            BL.CLS_Maison cLS_Maison = new BL.CLS_Maison();

            if (textMais.Text == "Nouvelle maison" || textMais.Text == "")
            {
                MessageBox.Show("Entrer nom de maison", "Ajout maison", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cLS_Maison.AjoutMais(textMais.Text) == false)
                {
                    MessageBox.Show("Maison déjà existante", "Ajout maison", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Maison créée", "Ajout maison", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (userMais as USR_Maison).remplirdata();
                }

            }

        }
    }
}
