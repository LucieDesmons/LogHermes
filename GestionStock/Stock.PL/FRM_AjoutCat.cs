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
    public partial class FRM_AjoutCat : Form
    {
        private UserControl usercat;
        public FRM_AjoutCat(UserControl userCategorie)
        {
            InitializeComponent();
            usercat = userCategorie;
        }

        private void btnQuitArt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textCat_Enter(object sender, EventArgs e)
        {
            if (textCat.Text == "Nouvelle catégorie")
            {
                textCat.Text = "";
                textCat.ForeColor = Color.Black;
            }
        }

        private void btnValidCat_Click(object sender, EventArgs e)
        {
            BL.CLS_categorie cLS_Categorie = new BL.CLS_categorie();

            if (textCat.Text == "Nouvelle catégorie" || textCat.Text == "")
            {
                MessageBox.Show("Entrer nom de catégorie","Ajout catégorie",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (cLS_Categorie.AjoutCat(textCat.Text) == false)
                {
                    MessageBox.Show("Catégorie déjà existante", "Ajout catégorie",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Catégorie créée", "Ajout catégorie",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    (usercat as USR_Categorie).remplirdata();
                }

            }
        }
    }
}
