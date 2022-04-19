using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock.Stock.PL
{
    public partial class FRM_Add_Employe : Form
    {
        public FRM_Add_Employe()
        {
            InitializeComponent();
        }
        string testobligatoire()
        {
            if (textNom.Text == "")
            {
                return "Entrer le nom";
            }
            if (textPrenom.Text == "")
            {
                return "Entrer le prénom";
            }
            if (textRole.Text == "")
            {
                return "Entrer le role";
            }

            return null;
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BL.CLS_Employe clEmploye = new BL.CLS_Employe();

                if (clEmploye.Ajouter_Employe(textNom.Text, textPrenom.Text, textRole.Text) == true)
                {
                    MessageBox.Show("Article crée", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Article déjà crée", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FRM_Add_Employe_Load(object sender, EventArgs e)
        {

        }
    }
}
