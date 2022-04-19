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
    public partial class FRM_Add_Client : Form
    {
        public FRM_Add_Client()
        {
            InitializeComponent();
        }

        //Tests obligatoires
        string testobligatoire()
        {
            if(textNom.Text=="" || textNom.Text=="Nom de client")
            {
                return "Entrer le nom de client";
            }
            if (textPrenom.Text == "" || textPrenom.Text == "Prénom client")
            {
                return "Entrer le prénom client";
            }
            if (textCp.Text == "")
            {
                return "Entrer le Code postal";
            }
            if (textVille.Text == "")
            {
                return "Entrer la ville";
            }
            if (textMail.Text == "")
            {
                return "Entrer le mail";
            }
            return null;
        }



        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox numeric
            if (e.KeyChar<48 || e.KeyChar>57)
            {
                e.Handled = true;
            }
            if(e.KeyChar == 8)
            {
                e.Handled=false;
            }
        }

        private void btnValidClt_Click(object sender, EventArgs e)
        {
            if(testobligatoire()!=null)
            {
                MessageBox.Show(testobligatoire(),"Obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textNom_Enter(object sender, EventArgs e)
        {
            if(textNom.Text == "Nom de client")
            {
                textNom.Text = "";
                textNom.ForeColor = Color.DarkCyan;
            }
        }

        private void textNom_Leave(object sender, EventArgs e)
        {
            if(textNom.Text == "")
            {
                textNom.Text = "Nom de client";
                textNom.ForeColor = Color.Silver;
            }
        }
    }
}
