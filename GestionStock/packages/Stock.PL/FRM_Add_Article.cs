using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Stock.Stock.PL


{
    public partial class FRM_Add_Article : Form
    {
        public FRM_Add_Article()
        {
            InitializeComponent();
        }

        string testobligatoire()
        {
            if (textNomVin.Text == "" || textNomVin.Text == "Millésime")
            {
                return "Entrer le millésime";
            }
            if (textCep.Text == "" || textCep.Text == "Cépage")
            {
                return "Entrer le cépage";
            }
            if (textPrix.Text == "")
            {
                return "Entrer le prix";
            }
            if (textAn.Text == "")
            {
                return "Entrer l'année";
            }
            if (textQte.Text == "")
            {
                return "Entrer la quantité";
            }
            return null;
        }



        private void textAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox numeric
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }



        private void textNomVin_Enter(object sender, EventArgs e)
        {
            if (textNomVin.Text == "Millésime")
            {
                textNomVin.Text = "";
                textNomVin.ForeColor = Color.DarkCyan;
            }
        }

        private void textNomVin_Leave(object sender, EventArgs e)
        {
            if (textCep.Text == "")
            {
                textCep.Text = "Millésime";
                textCep.ForeColor = Color.Silver;
            }
        }
        private void textCep_Enter(object sender, EventArgs e)
        {
            if (textNomVin.Text == "Cépage")
            {
                textNomVin.Text = "";
                textNomVin.ForeColor = Color.DarkCyan;
            }
        }

        private void textCep_Leave(object sender, EventArgs e)
        {
            if (textCep.Text == "")
            {
                textCep.Text = "Cépage";
                textCep.ForeColor = Color.Silver;
            }
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BL.CLS_Article clArticle = new BL.CLS_Article();

                //bool Ajout = clArticle.Ajouter_Article(textNomVin.Text, textDescription.Text, textCep.Text, int.Parse(textAn.Text), decimal.Parse(textNote.Text), decimal.Parse(textPrix.Text), int.Parse(textQte.Text), int.Parse(textCat.Text)) ;
                bool Ajout = clArticle.Ajouter_Article("rttf", "blablabla", "blibli", 2020, 5, 10, 10,1);
                if ( Ajout == true)
                {
                    MessageBox.Show("Article crée", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Article déjà crée", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FRM_Add_Article_Load(object sender, EventArgs e)
        {

        }
    }
}
