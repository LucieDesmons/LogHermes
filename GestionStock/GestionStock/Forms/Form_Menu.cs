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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(200, 529);
            panelParam.Visible = false;
        }
        //Bouton arrêt quitter le programme
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Bouton réduction fenêtre
        private void btnReduce_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Bouton repli de fenêtre
        private void button3_Click(object sender, EventArgs e)
        {
            if(panel1.Width == 200)
            {
                panel1.Size = new Size(61, 531);
            }else
            {
                panel1.Size = new Size(200, 531);
            }
        }
        //Panel suivi du label
        private void btnProduit_Click(object sender, EventArgs e)
        {
            panBtn.Top = btnProduit.Top;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            panBtn.Top = btnClient.Top;
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            panBtn.Top = btnCategorie.Top;
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            panBtn.Top = btnCommande.Top;
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            panBtn.Top = btnUtilisateur.Top;
        }

        private void btnParam_Click(object sender, EventArgs e)
        {
            panelParam.Size = new Size(402, 200);
            panelParam.Visible = !panelParam.Visible;
        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {
            panBtn.Top = btnStock.Top;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Form_Connexion frmC = new Form_Connexion();
            frmC.ShowDialog();
        }
    }
}
