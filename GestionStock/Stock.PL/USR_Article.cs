using Microsoft.Office.Interop.Excel;
using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GestionStock.Stock.PL
{
    public partial class USR_Article : UserControl
    {
        private static USR_Article UserArticle;
        private dbStockContext db;
        //création d'une instance pour le usercontrol
        public static USR_Article Instance
        {
            get
            {
                if (UserArticle == null)
                {
                    UserArticle = new USR_Article();
                }
                return UserArticle;
            }
        }

        public USR_Article()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        public void Actualiserdgv()
        {
            db = new dbStockContext();
            dgvProduit.Rows.Clear();
            CATEGORIE Cat = new CATEGORIE();
            MAISON Mais = new MAISON();
            foreach (var Prod in db.PRODUIT)
            {
                Mais = db.MAISON.SingleOrDefault(m => m.ID_MAISON == Prod.ID_MAISON);
                Cat = db.CATEGORIE.SingleOrDefault(s => s.Id_Categorie == Prod.Id_Categorie);
                if (Cat != null)
                {
                    dgvProduit.Rows.Add(false,Prod.Id_Produit, Prod.Nom_Produit, Prod.Annee_Produit, Prod.Quantite_Produit, Prod.Prix_Unitaire,Prod.Prix_Carton_Produit, Mais.Nom_Maison, Cat.Nom_Categorie, Prod.Description_Produit);

                }
            }

            //Colore le stock à 0
            for (int i = 0;i< dgvProduit.Rows.Count;i++)
            {
                if((int)dgvProduit.Rows[i].Cells[4].Value == 0)
                {
                    dgvProduit.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
                else
                {
                    dgvProduit.Rows[i].Cells[4].Style.BackColor = Color.LightGreen;
                }
            }
        }

        private void btnAddProduct_Click(object sender, System.EventArgs e)
        {
            PL.FRM_AjoutArt frmArticle = new PL.FRM_AjoutArt(this);
            frmArticle.ShowDialog();
        }
        public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0; i < dgvProduit.Rows.Count; i++)
            {
                if ((bool)dgvProduit.Rows[i].Cells[0].Value == true)
                {
                    Nombreligneselect++;
                }
            }
            if (Nombreligneselect == 0)
            {
                return "Sélectionner un article";
            }
            if (Nombreligneselect > 1)
            {
                return "Sélectionner un seul article";
            }
            return null;
        }

        private void btnModArt_Click(object sender, System.EventArgs e)
        {
            PRODUIT PR = new PRODUIT();
            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PL.FRM_AjoutArt frmArticle = new PL.FRM_AjoutArt(this);
                frmArticle.lblFicheArt.Text = "Modification article";
                frmArticle.btnAnnulerArt.Visible = false;
                for (int i = 0; i < dgvProduit.Rows.Count; i++)
                {

                    if ((bool)dgvProduit.Rows[i].Cells[0].Value == true)//si la checkbox est cochée
                    {
                        int MYIDSELECT = (int)dgvProduit.Rows[i].Cells[1].Value;//n°ID sélectionné
                        PR = db.PRODUIT.SingleOrDefault(p => p.Id_Produit == MYIDSELECT);// id produit = id sélectionné dans datagridview

                        if (PR != null)//si existe
                        {
                            frmArticle.Id_Produit = (int)dgvProduit.Rows[i].Cells[1].Value;
                            frmArticle.textDenomination.Text = dgvProduit.Rows[i].Cells[2].Value.ToString();
                            frmArticle.textAn.Text = dgvProduit.Rows[i].Cells[3].Value.ToString();
                            frmArticle.textQteArt.Text = dgvProduit.Rows[i].Cells[4].Value.ToString();
                            frmArticle.textPrix.Text = dgvProduit.Rows[i].Cells[5].Value.ToString();
                            frmArticle.textPxCarton.Text = dgvProduit.Rows[i].Cells[6].Value.ToString();
                            frmArticle.comboMaisArt.Text = dgvProduit.Rows[i].Cells[7].ToString();
                            frmArticle.comboCatArt.Text = dgvProduit.Rows[i].Cells[8].Value.ToString();
                            frmArticle.textDescription.Text = dgvProduit.Rows[i].Cells[9].Value.ToString();
                            

                            MemoryStream MS = new MemoryStream(PR.Image_Produit);
                            frmArticle.picArt.Image = Image.FromStream(MS);
                        }
                    }

                }


                frmArticle.ShowDialog();
            }

        }

        private void USR_Article_Load(object sender, System.EventArgs e)
        {
            Actualiserdgv();
        }

        private void btnPicture_Click(object sender, System.EventArgs e)
        {
            PRODUIT PR = new PRODUIT();
            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(), "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < dgvProduit.Rows.Count; i++) //Vérifie la ligne sélectionnée
                {
                    if ((bool)dgvProduit.Rows[i].Cells[0].Value == true)//si la checkbox est cochée
                    {
                        int MYIDSELECT = (int)dgvProduit.Rows[i].Cells[1].Value;//n°ID sélectionné
                        PR = db.PRODUIT.SingleOrDefault(p => p.Id_Produit == MYIDSELECT);// id produit = id sélectionné dans datagridview

                        if (PR != null)//si existe
                        {
                            FRM_Image frmPhoto = new FRM_Image();
                            MemoryStream MS = new MemoryStream(PR.Image_Produit);//Pb

                            frmPhoto.picImageProduit.Image = Image.FromStream(MS);

                            frmPhoto.lblImage.Text = dgvProduit.Rows[i].Cells[2].Value.ToString();
                            //afficher le formulaire
                            frmPhoto.ShowDialog();
                        }
                    }

                }

            }
        }

        private void btnSuppArt_Click(object sender, System.EventArgs e)
        {
            if (SelectVerif() == "Sélectionner un article")
            {
                MessageBox.Show(SelectVerif(), "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult DR = MessageBox.Show("Voulez-vous supprimer l'article sélectionné ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvProduit.Rows.Count; i++)
                    {
                        if ((bool)dgvProduit.Rows[i].Cells[0].Value == true)
                        {
                            BL.CLS_Article cLS_Article = new BL.CLS_Article();
                            int idselect = (int)dgvProduit.Rows[i].Cells[1].Value;
                            cLS_Article.Supp_Produit(idselect);
                        }
                    }
                    Actualiserdgv();
                    MessageBox.Show("Produit supprimé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression annulée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void textBoxR_TextChanged(object sender, System.EventArgs e)
        {
            db = new dbStockContext();
            var listerecherche = db.PRODUIT.ToList();//listerecherche = liste des clients
            if (textBoxR.Text != "")//recherche non vide
            {
                switch (comboRech.Text)
                {
                    case "Nom":
                        listerecherche = listerecherche.Where(s => s.Nom_Produit.IndexOf(textBoxR.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        //StringComparison.CurrentCultureIgnoreCase => soit 1ere lettre en majuscule soit minuscule
                        //!=-1 existe dans la BDD
                        break;
                    /*case "Prix":
                        listerecherche = listerecherche.Where(s => s.Année.IndexOf(textBoxR.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;*/


                }
            }
            dgvProduit.Rows.Clear();
            CATEGORIE cat = new CATEGORIE();
            MAISON mais = new MAISON();

            foreach (var l in listerecherche)
            {
                mais = db.MAISON.SingleOrDefault(m =>m.ID_MAISON == m.ID_MAISON);
                cat = db.CATEGORIE.SingleOrDefault(s => s.Id_Categorie == l.Id_Categorie);
                dgvProduit.Rows.Add(false, l.Id_Produit, l.Nom_Produit, l.Annee_Produit, l.Description_Produit, l.Prix_Carton_Produit, l.Quantite_Produit, l.Prix_Unitaire, mais.Nom_Maison, cat.Nom_Categorie) ;
            }
        }
        //Vérifier le nombre de lignes sélectionnées

        private void btnImpr_Click(object sender, EventArgs e)
        {
            db = new dbStockContext();
            int idselect = 0;
            string Nomcategorie = null;
            Report.FRM_Report frmpt = new Report.FRM_Report();
            PRODUIT PR = new PRODUIT();
            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(), "Imprimer Produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < dgvProduit.Rows.Count; i++)
                {
                    if ((bool)dgvProduit.Rows[i].Cells[0].Value == true)
                    {
                        idselect = (int)dgvProduit.Rows[i].Cells[1].Value;
                        Nomcategorie = dgvProduit.Rows[i].Cells[8].Value.ToString();
                    }
                }
                PR = db.PRODUIT.SingleOrDefault(s => s.Id_Produit == idselect);
                if (PR != null)
                {
                    frmpt.rpAfficher.LocalReport.ReportEmbeddedResource = "GestionStock.Report.Rpt_Produit.rdlc";
                    ReportParameter Pcategorie = new ReportParameter("@RPCategorie", Nomcategorie);
                    ReportParameter Pnom = new ReportParameter("@RPNom", PR.Nom_Produit);
                    ReportParameter Pquantite = new ReportParameter("@RPQuantite", PR.Quantite_Produit.ToString());
                    ReportParameter Pprix = new ReportParameter("@RPPrix", PR.Prix_Unitaire.ToString());
                    string ImageString = Convert.ToBase64String(PR.Image_Produit);
                    ReportParameter Pimage = new ReportParameter("@RPImage", ImageString);
                    frmpt.rpAfficher.LocalReport.SetParameters(new ReportParameter[] { Pcategorie, Pnom, Pquantite, Pprix, Pimage });
                    frmpt.rpAfficher.RefreshReport();
                    frmpt.ShowDialog();

                }
            }
        }

        private void btnImprAll_Click(object sender, EventArgs e)
        {
            db = new dbStockContext();
            Report.FRM_Report frrmpt = new Report.FRM_Report();
            try
            {
                var listeArticle = db.PRODUIT.ToList();
                frrmpt.rpAfficher.LocalReport.ReportEmbeddedResource = "GestionStock.Report.Rpt_listeProduit.rdlc";
                frrmpt.rpAfficher.LocalReport.DataSources.Add(new ReportDataSource("DatabaseProduit", listeArticle));
                ReportParameter date = new ReportParameter("@Date", DateTime.Now.ToString());
                frrmpt.rpAfficher.LocalReport.SetParameters(new ReportParameter[] { date });
                frrmpt.rpAfficher.RefreshReport();
                frrmpt.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnExportXls_Click(object sender, EventArgs e)
        {
            db = new dbStockContext();
            using (SaveFileDialog SFD = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (SFD.ShowDialog() == DialogResult.OK)
                {


                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Id Produit";
                    ws.Cells[1, 2] = "Nom Produit";
                    ws.Cells[1, 3] = "Quantité";
                    ws.Cells[1, 4] = "Prix unitaire";

                    var ListeProduit = db.PRODUIT.ToList();
                    int i = 2;
                    foreach (var L in ListeProduit)
                    {

                        ws.Cells[i, 1] = L.Id_Produit;
                        ws.Cells[i, 2] = L.Nom_Produit;
                        ws.Cells[i, 3] = L.Quantite_Produit;
                        ws.Cells[i, 4] = L.Prix_Unitaire;
                        i++;
                    }

                    ws.Range["A1:D1"].Interior.Color = Color.Teal;
                    ws.Range["A1:D1"].Font.Color = Color.White;
                    ws.Range["A1:D1"].Font.Size = 15;
                    ws.Range["A:D"].HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    wb.SaveAs(SFD.FileName);
                    app.Quit();
                    MessageBox.Show("Sauvegarde dans Excel", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void comboRech_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

