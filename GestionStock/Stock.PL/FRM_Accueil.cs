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
    public partial class FRM_Accueil : Form
    {
        public FRM_Accueil()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (!pnlAfficher.Controls.Contains(USR_Client.Instance))
            {
                pnlAfficher.Controls.Add(USR_Client.Instance);
                USR_Client.Instance.Dock = DockStyle.Fill;
                USR_Client.Instance.BringToFront();
            }
            else
            {
                USR_Client.Instance.BringToFront();
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (!pnlAfficher.Controls.Contains(USR_Article.Instance))
            {
                pnlAfficher.Controls.Add(USR_Article.Instance);
                USR_Article.Instance.Dock = DockStyle.Fill;
                USR_Article.Instance.BringToFront();
            }
            else
            {
                USR_Article.Instance.BringToFront();
            }

        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            if(!pnlAfficher.Controls.Contains(USR_Categorie.Instance))
            {
                pnlAfficher.Controls.Add(USR_Categorie.Instance);
                USR_Categorie.Instance.Dock = DockStyle.Fill;
                USR_Categorie.Instance.BringToFront();
            }
            else
            {
                USR_Categorie.Instance.BringToFront();
            }
        }

        private void btnCmde_Click(object sender, EventArgs e)
        {
            if (!pnlAfficher.Controls.Contains(USR_Commande.Instance))
            {
                pnlAfficher.Controls.Add(USR_Commande.Instance);
                USR_Commande.Instance.Dock = DockStyle.Fill;
                USR_Commande.Instance.BringToFront();
            }
            else
            {
                USR_Commande.Instance.BringToFront();
            }
        }

        private void btnMaison_Click(object sender, EventArgs e)
        {
            if (!pnlAfficher.Controls.Contains(USR_Maison.Instance))
            {
                pnlAfficher.Controls.Add(USR_Maison.Instance);
                USR_Maison.Instance.Dock = DockStyle.Fill;
                USR_Maison.Instance.BringToFront();
            }
            else
            {
                USR_Maison.Instance.BringToFront();
            }

        }
    }
}
