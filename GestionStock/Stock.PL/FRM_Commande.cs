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
    public partial class FRM_Commande : Form
    {
        private dbStockContext db;
        public FRM_Commande()
        {
            InitializeComponent();
            db = new dbStockContext();
        }
        //Remplir le datagrid produit
        public void Actualise_DetailCommande()
        {
            dgvCommande.Rows.Clear();
            foreach(var L in BL.DetailCmde.listeDetail)
            {
                dgvCommande.Rows.Add(L.Id, L.Nom, L.quantite, L.prix, L.remise, L.total);
            }
        }

        //Fonction remplir data produit
        public void remplirdgvProduit()
        {
            db = new dbStockContext();
            foreach(var l in db.PRODUIT)
            {
                dgvProduit.Rows.Add(l.Id_Produit,l.Nom_Produit,l.Quantite_Produit,l.Prix_Produit);

            }
            for (int i = 0; i < dgvProduit.Rows.Count; i++)
            {
                if ((int)dgvProduit.Rows[i].Cells[2].Value == 0)
                {
                    dgvProduit.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
                else
                {
                    dgvProduit.Rows[i].Cells[2].Style.BackColor = Color.LightGreen;
                }
            }
            dgvProduit.ClearSelection();
        }

        private void FRM_Commande_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gESTION_STOCKDataSet1.Details_Commande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.details_CommandeTableAdapter.Fill(this.gESTION_STOCKDataSet1.Details_Commande);
            remplirdgvProduit();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBoxR_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtBoxR_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
            var listerecherche = db.PRODUIT.ToList();
            listerecherche = listerecherche.Where(s => s.Nom_Produit.IndexOf(txtBoxR.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            dgvProduit.Rows.Clear();
            foreach (var l in listerecherche)
            {
                dgvProduit.Rows.Add(l.Id_Produit, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit);
            }
        }

        private void btnClt_Click(object sender, EventArgs e)
        {
            PL.FRM_Client_Commande fRM_Client_Commande = new PL.FRM_Client_Commande();
            fRM_Client_Commande.ShowDialog();
            textNom.Text = fRM_Client_Commande.dgvClient.CurrentRow.Cells[1].Value.ToString();
            textPrenom.Text = fRM_Client_Commande.dgvClient.CurrentRow.Cells[2].Value.ToString();
            textAdresse.Text = fRM_Client_Commande.dgvClient.CurrentRow.Cells[3].Value.ToString();
            textVille.Text = fRM_Client_Commande.dgvClient.CurrentRow.Cells[4].Value.ToString();
            textPays.Text = fRM_Client_Commande.dgvClient.CurrentRow.Cells[5].Value.ToString();
            textTel.Text = fRM_Client_Commande.dgvClient.CurrentRow.Cells[6].Value.ToString();
            textMail.Text = fRM_Client_Commande.dgvClient.CurrentRow.Cells[7].Value.ToString();
        }

        private void dgvProduit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Produit_Commande fRM_Produit_Commande = new FRM_Produit_Commande(this);
            if ((int)dgvProduit.CurrentRow.Cells[2].Value == 0)
            {
                MessageBox.Show("Stock vide", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fRM_Produit_Commande.lblId.Text = dgvProduit.CurrentRow.Cells[0].Value.ToString();
                fRM_Produit_Commande.lblNom.Text = dgvProduit.CurrentRow.Cells[1].Value.ToString();
                fRM_Produit_Commande.lblStock.Text = dgvProduit.CurrentRow.Cells [2].Value.ToString();
                fRM_Produit_Commande.lblPrix.Text = dgvProduit.CurrentRow.Cells[3].Value.ToString();
                fRM_Produit_Commande.textTotal.Text = dgvProduit.CurrentRow.Cells[3].Value.ToString();
                fRM_Produit_Commande.ShowDialog();
            }
        }
    }
}
