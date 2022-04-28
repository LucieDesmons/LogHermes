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
        private UserControl userCommande;
        private dbStockContext db;
        public FRM_Commande(UserControl user)
        {
            InitializeComponent();
            db = new dbStockContext();
            userCommande = user;
        }
        //Remplir le datagrid produit
        public void Actualise_DetailCommande()
        {
            //Calcul de la facturation HT, TVA, TTC
            float totalHT = 0, TVA = 20, totalTTC = 0;
            if(txtTVA.Text !="")
            {
                TVA= float.Parse(txtTVA.Text);
            }
            dgvCommande.Rows.Clear();
            foreach(var L in BL.DetailCmde.listeDetail)
            {
                dgvCommande.Rows.Add(L.Id, L.Nom, L.quantite, L.prix, L.remise, L.total);
                totalHT = totalHT+float.Parse(L.total);
            }
            txtTHT.Text = totalHT.ToString();
            totalTTC = (totalHT + (totalHT * TVA / 100));
            txtTTTC.Text = totalTTC.ToString();
            txtTVA.Text = TVA.ToString();
        }

        //Fonction remplir data produit
        public void remplirdgvProduit()
        {
            db = new dbStockContext();
            foreach(var l in db.PRODUIT)
            {
                dgvProduit.Rows.Add(l.Id_Produit,l.Nom_Produit,l.Quantite_Produit,l.Prix_Unitaire, l.Annee_Produit,l.Description_Produit, l.Prix_Carton_Produit);

            }
            for (int i = 0; i < dgvProduit.Rows.Count; i++)
            {
                if ((int)dgvProduit.Rows[i].Cells[4].Value == 0)
                {
                    dgvProduit.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
                else
                {
                    dgvProduit.Rows[i].Cells[4].Style.BackColor = Color.LightGreen;
                }
            }
            dgvProduit.ClearSelection();
        }

        private void FRM_Commande_Load(object sender, EventArgs e)
        {

            remplirdgvProduit();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
            //Vider le datagrid après validation commande
            BL.DetailCmde.listeDetail.Clear();
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
                dgvProduit.Rows.Add(l.Id_Produit, l.Nom_Produit, l.Quantite_Produit, l.Prix_Unitaire, l.Annee_Produit, l.Description_Produit, l.Prix_Carton_Produit);
            }
        }

        private void btnClt_Click(object sender, EventArgs e)
        {
            PL.FRM_Client_Commande fRM_Client_Commande = new PL.FRM_Client_Commande();
            fRM_Client_Commande.ShowDialog();
            IDClient = (int)fRM_Client_Commande.dgvClient.CurrentRow.Cells[0].Value;
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

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_Produit_Commande fRM_Produit_Commande = new FRM_Produit_Commande(this);
            PRODUIT PR = new PRODUIT();
            if(dgvCommande.CurrentRow!= null)
            {
                fRM_Produit_Commande.gbArticle.Text = "Article à modifier";
                fRM_Produit_Commande.lblId.Text = dgvCommande.CurrentRow.Cells[0].Value.ToString();
                fRM_Produit_Commande.lblNom.Text = dgvCommande.CurrentRow.Cells[1].Value.ToString();
                int IDP = int.Parse(dgvCommande.CurrentRow.Cells[0].Value.ToString());
               
                PR = db.PRODUIT.Single(s=>s.Id_Produit == IDP);
                fRM_Produit_Commande.lblStock.Text = PR.Quantite_Produit.ToString();
                fRM_Produit_Commande.lblPrix.Text = dgvCommande.CurrentRow.Cells[3].Value.ToString();
                fRM_Produit_Commande.textQte.Text = dgvCommande.CurrentRow.Cells[2].Value.ToString();
                fRM_Produit_Commande.textRemise.Text = dgvCommande.CurrentRow.Cells[4].Value.ToString();
                fRM_Produit_Commande.textTotal.Text = dgvCommande.CurrentRow.Cells[5].Value.ToString();
                fRM_Produit_Commande.ShowDialog();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCommande.CurrentRow != null)
            {
                DialogResult PR = MessageBox.Show("Supprimer votre commande ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (PR == DialogResult.Yes)
                {
                    int index = BL.DetailCmde.listeDetail.FindIndex(s => s.Id == int.Parse(dgvCommande.CurrentRow.Cells[0].Value.ToString()));
                    BL.DetailCmde.listeDetail.RemoveAt(index);

                    Actualise_DetailCommande();
                    MessageBox.Show("Commande supprimée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }else
                {
                    MessageBox.Show("Suppression annulée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtTVA_TextChanged(object sender, EventArgs e)
        {
            Actualise_DetailCommande();
        }
        public int IDClient;

        private void btnValidClt_Click(object sender, EventArgs e)
        {
            BL.CLS_Commande_DetailCommande clsCommande = new BL.CLS_Commande_DetailCommande();
            if (dgvCommande.Rows.Count == 0)
            {
                MessageBox.Show("Ajouter un/des produit(s)","Enregistrer", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (textNom.Text == "")
                {
                    MessageBox.Show("Ajouter un client", "client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Enregistrer la commande
                    clsCommande.Ajouter_Commande(dateCommande.Value,IDClient,txtTHT.Text,txtTVA.Text,txtTTTC.Text);
                    //Sauvegarder dans la base de données
                    foreach(var LD in BL.DetailCmde.listeDetail)
                    {
                        clsCommande.Ajouter_Detail(LD.Id, LD.Nom, LD.quantite, LD.prix, LD.remise, LD.total);
                    }
                    (userCommande as USR_Commande).remplirdata();
                    BL.DetailCmde.listeDetail.Clear();
                    Close();
                    MessageBox.Show("Commande ajouter avec succès", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
