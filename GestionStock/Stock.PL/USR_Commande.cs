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
    public partial class USR_Commande : UserControl
    {
        private static USR_Commande UserCommande;
        private dbStockContext db;
        public static USR_Commande Instance
        {
            get
            {
                if (UserCommande == null)
                {
                    UserCommande = new USR_Commande();
                }
                return UserCommande;
            }

        }
        public USR_Commande()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        //Remplir datagrid
        public void remplirdata()
        {
            dgvCmde.Rows.Clear();
            CLIENT c = new CLIENT();
            string NomPrenom;
            foreach(var LC in db.COMMANDE)
            {
                //Afficher Nom+Prenom client 
                c = db.CLIENT.Single(s => s.Id_Client == LC.Id_Client);
                NomPrenom = c.Nom_Client + " " + c.Prenom_Client;
                dgvCmde.Rows.Add(LC.Id_Commande, LC.Date_Commande, NomPrenom, LC.Total_HT, LC.TVA, LC.Total_TTC);

            }
        }
        private void USR_Commande_Load(object sender, EventArgs e)
        {
            remplirdata();
        }

        private void btnAddCmde_Click(object sender, EventArgs e)
        {
            PL.FRM_Commande fRM_Commande = new FRM_Commande(this);
            fRM_Commande.ShowDialog();
        }

        private void btnRechCmde_Click(object sender, EventArgs e)
        {
            var listecommande = db.COMMANDE.ToList();// Liste des commandes
            if (dgvCmde.Rows.Count != 0)
            {
                listecommande = listecommande.Where(s=>s.Date_Commande.Date >= dateDebut.Value.Date && s.Date_Commande.Date <= dateFin.Value.Date).ToList();
                dgvCmde.Rows.Clear();
                CLIENT c = new CLIENT();
                string NomPrenom;
                foreach(var LC in listecommande)
                {
                    c = db.CLIENT.Single(s => s.Id_Client == LC.Id_Client);
                    NomPrenom = c.Nom_Client + " " + c.Prenom_Client;
                    dgvCmde.Rows.Add(LC.Id_Commande, LC.Date_Commande, NomPrenom, LC.Total_HT, LC.TVA, LC.Total_TTC);

                }
            }
        }

        private void btnImpr_Click(object sender, EventArgs e)
        {
            Report.FRM_Report fRM_Report = new Report.FRM_Report();
            db = new dbStockContext();
            try
            {
                //commande selectionnée
                int IdCommande = (int)dgvCmde.CurrentRow.Cells[0].Value;
                var Commande=db.COMMANDE.Single(s=> s.Id_Commande == IdCommande);
                var ClientCommande = db.CLIENT.Single(s=> s.Id_Client == Commande.Id_Client);
                var listedetail = db.Details_Commande.Where(s => s.Id_Commande == IdCommande).ToList();


            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
