using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GestionStock.Stock.PL
{
    public partial class USR_Client : UserControl
    {
        private static USR_Client UserClient;
        private dbStockContext db;
        //création d'une instance pour le usercontrol
        public static USR_Client Instance
        {
            get
            {
                if (UserClient == null)
                {
                    UserClient = new USR_Client();
                }
                return UserClient;
            }
        }

        public USR_Client()
        {
            InitializeComponent();
            db = new dbStockContext();
            //désactive textbox de recherche
            textBoxR.Enabled = false;// le textbox recherche désactivé
        }


        public void ActualiseDataGrid()
        {
            db = new dbStockContext();
            dgvClient.Rows.Clear();//vider la datagrid
            //Ajoute les lignes dans le datagrid
            foreach (var S in db.CLIENT)
            {
                dgvClient.Rows.Add(S.Id_Client, S.Nom_Client, S.Prenom_Client, S.Adresse_Client, S.Ville_Client, S.Pays_Client, S.Telephone_Client, S.Email_Client, false);
            }
        }

        //Vérifier le nombre de lignes sélectionnées
        public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0; i < dgvClient.Rows.Count; i++)
            {
                if ((bool)dgvClient.Rows[i].Cells[8].Value == true)
                {
                    Nombreligneselect++;
                }
            }
            if (Nombreligneselect == 0)
            {
                return "Sélectionner le client à modifier";
            }
            if (Nombreligneselect > 1)
            {
                return "Sélectionner un seul client à modifier";
            }
            return null;
        }

        private void textBoxR_Enter(object sender, EventArgs e)
        {
            if (textBoxR.Text == "Rechercher...")
            {
                textBoxR.Text = "";
                textBoxR.ForeColor = Color.Black;

            }
        }
        private void USR_Client_Load(object sender, EventArgs e)
        {
            ActualiseDataGrid();

        }


        private void btnAddClient_Click(object sender, EventArgs e)
        {
            //Affiche le formulaire de saisie
            PL.FRM_AjoutClt frmClt = new PL.FRM_AjoutClt(this);
            frmClt.ShowDialog();
        }

        private void btnModClient_Click(object sender, EventArgs e)
        {
            PL.FRM_AjoutClt frmClt = new PL.FRM_AjoutClt(this);
            if (SelectVerif() == null)
            {
                for (int i = 0; i < dgvClient.Rows.Count; i++)
                {
                    if ((bool)dgvClient.Rows[i].Cells[8].Value == true)// si le checkbox est coché, affiche les informations du client
                    {
                        frmClt.IDselect = (int)dgvClient.Rows[i].Cells[0].Value;
                        frmClt.textNom.Text = (string)dgvClient.Rows[i].Cells[1].Value;
                        frmClt.textPrenom.Text = (string)dgvClient.Rows[i].Cells[2].Value;
                        frmClt.textAdresse.Text = (string)dgvClient.Rows[i].Cells[3].Value;
                        frmClt.textVille.Text = (string)dgvClient.Rows[i].Cells[4].Value;
                        frmClt.textPays.Text = (string)dgvClient.Rows[i].Cells[5].Value;
                        frmClt.textTel.Text = (string)dgvClient.Rows[i].Cells[6].Value;
                        frmClt.textMail.Text = (string)dgvClient.Rows[i].Cells[7].Value;

                    }
                }
                frmClt.lblFicheClt.Text = "Fiche modification";
                frmClt.btnValidClt.Text = "Actualiser";
                frmClt.btnAnnuler.Visible = false;//FRM_AjoutClt.lblFicheClt est inaccessible en raison de son niveau de protection
                frmClt.ShowDialog();
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSuppClient_Click(object sender, EventArgs e)
        {
            BL.CLS_Client clclient = new BL.CLS_Client();
            int select = 0;
            for (int i = 0; i < dgvClient.Rows.Count; i++)
            {
                if ((bool)dgvClient.Rows[i].Cells[8].Value == true)
                {
                    select++;
                }
            }
            if (select == 0)
            {
                MessageBox.Show("Aucun client sélectionné", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult R =
                MessageBox.Show("Voulez-vous supprimer le client ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    //Supprime toutes les lignes sélectionnées
                    for (int i = 0; i < dgvClient.Rows.Count; i++)
                    {
                        if ((bool)dgvClient.Rows[i].Cells[8].Value == true)
                        {
                            clclient.Supp_Client(int.Parse(dgvClient.Rows[i].Cells[0].Value.ToString()));
                        }

                    }
                    //actualiser datagrid
                    ActualiseDataGrid();
                    MessageBox.Show("Client supprimé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression annulée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void comboRech_SelectedIndexChanged(object sender, EventArgs e)
        {
            //active le textBox une fois un champ choisi
            textBoxR.Enabled = true;
            textBoxR.Text = "";
        }

        private void textBoxR_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
            var listerecherche = db.CLIENT.ToList();//listerecherche = liste des clients
            if(textBoxR.Text !="")//recherche non vide
            {
                switch(comboRech.Text)
                {
                    case "Nom":
                        listerecherche=listerecherche.Where(s =>s.Nom_Client.IndexOf(textBoxR.Text, StringComparison.CurrentCultureIgnoreCase)!=-1).ToList();
                        //StringComparison.CurrentCultureIgnoreCase => soi 1ere lettre en majuscule soi minuscule
                        //!=-1 existe dans la BDD
                        break;
                    case "Prénom":
                       listerecherche = listerecherche.Where(s => s.Prenom_Client.IndexOf(textBoxR.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Adresse":
                        listerecherche = listerecherche.Where(s => s.Adresse_Client.IndexOf(textBoxR.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Ville":
                        listerecherche = listerecherche.Where(s => s.Ville_Client.IndexOf(textBoxR.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Pays":
                        listerecherche = listerecherche.Where(s => s.Pays_Client.IndexOf(textBoxR.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Email":
                        listerecherche = listerecherche.Where(s => s.Email_Client.IndexOf(textBoxR.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Telephone":
                        listerecherche = listerecherche.Where(s => s.Telephone_Client.IndexOf(textBoxR.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;

                }
            }
            dgvClient.Rows.Clear();
            foreach(var l in listerecherche)
            {
                dgvClient.Rows.Add(l.Id_Client, l.Nom_Client, l.Prenom_Client, l.Adresse_Client, l.Ville_Client,l.Email_Client,l.Telephone_Client,l.Pays_Client, false);
            }
        }
    }
}
