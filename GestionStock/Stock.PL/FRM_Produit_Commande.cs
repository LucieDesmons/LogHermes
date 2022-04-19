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
    public partial class FRM_Produit_Commande : Form
    {
        public Form frmdetail;
        public FRM_Produit_Commande(Form frm)
        {
            InitializeComponent();
            frmdetail = frm;
        }

        private void textQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (e.KeyChar == 44 || e.KeyChar == 46) //code asci des n° et . et ,)
            {
                e.Handled = false;
            }
        }

        private void textRemise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (e.KeyChar == 44 || e.KeyChar == 46) //code asci des n° et . et ,)
            {
                e.Handled = false;
            }
        }

        private void textQte_TextChanged(object sender, EventArgs e)
        {
            if(textQte.Text != "")
            {
                
                int quantite = int.Parse(textQte.Text);
                int prix = int.Parse(lblPrix.Text);
                if (int.Parse(textQte.Text)>int.Parse(lblStock.Text))
                {
                    MessageBox.Show(int.Parse(lblStock.Text) + "produit(s) restant(s) dans le stock", "StockProduit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textQte.Text = "";
                    textTotal.Text = lblPrix.Text;
                }
                else
                {
                    textTotal.Text = (quantite * prix).ToString();
                }

            }
            else
            {
                textTotal.Text = lblPrix.Text;
            }

        }

        private void textRemise_TextChanged(object sender, EventArgs e)
        {
            if(textRemise.Text !="")
            {
                int quantite;
                if (textQte.Text != "")
                {
                    quantite = int.Parse(textQte.Text);
                }
                else
                {
                    quantite = 1;
                }

                int prix = int.Parse(lblPrix.Text);
                int total = quantite * prix;
                int remise = int.Parse(textRemise.Text);
                textTotal.Text = (total - (total * remise/100)).ToString();
            }
            else
            {
                int quantite;
                if (textQte.Text != "")
                {
                    quantite = int.Parse(textQte.Text);
                }
                else
                {
                    quantite = 1;
                }
                int prix = int.Parse(lblPrix.Text);
                textTotal.Text = (quantite * prix).ToString();
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //si txtbox qté et remise vide
            int Quant, Rem;
            if (textQte.Text!="")
            {
                Quant=int.Parse(textQte.Text);
            }
            else
            {
                Quant=1;
            }
            if (textRemise.Text != "")
            {
                Rem = int.Parse(textRemise.Text);
            }
            else
            {
                Rem = 0;
            }
            //Ajout du/des produits dans commande
            BL.DetailCmde detailCmde = new BL.DetailCmde()
            {
                Id = int.Parse(lblId.Text),
                Nom = lblNom.Text,
                quantite = Quant,
                prix = lblPrix.Text,
                remise = Rem.ToString(),
                total = textTotal.Text,
            };
            //Ajout dans la liste
            if (BL.DetailCmde.listeDetail.SingleOrDefault(s => s.Id == detailCmde.Id) != null)
            {
                MessageBox.Show("Produit déjà commandé","Commande", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { BL.DetailCmde.listeDetail.Add(detailCmde); }
            //Actualise datagrid
            (frmdetail as FRM_Commande).Actualise_DetailCommande();

        }
    }
}
