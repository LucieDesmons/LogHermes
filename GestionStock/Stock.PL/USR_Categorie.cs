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
    public partial class USR_Categorie : UserControl
    {
        private static USR_Categorie UserCategorie;
        private dbStockContext db;
        //création d'une instance pour le usercontrol
        public static USR_Categorie Instance
        {
            get
            {
                if (UserCategorie == null)
                {
                    UserCategorie = new USR_Categorie();
                }
                return UserCategorie;
            }
        }
        public USR_Categorie()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        public void remplirdata()
        {
            db = new dbStockContext();
            dgvCat.Rows.Clear();
            foreach(var Cat in db.CATEGORIE)
            {
                dgvCat.Rows.Add(false, Cat.Id_Categorie,Cat.Nom_Categorie);
            }
        }

        private void textBoxR_TextChanged(object sender, EventArgs e)
        {
            if(textBoxR.Text == "Recherche...")
            {
                textBoxR.Text = "";
                textBoxR.ForeColor = Color.Black;
            }
            var maliste = db.CATEGORIE.ToList();
            maliste = maliste.Where(s => s.Nom_Categorie.IndexOf(textBoxR.Text,StringComparison.CurrentCultureIgnoreCase)!=-1).ToList();
            dgvCat.Rows.Clear();
            foreach(var l in maliste)
            {
                dgvCat.Rows.Add(false, l.Id_Categorie, l.Nom_Categorie);
            }

        }

        private void USR_Categorie_Load(object sender, EventArgs e)
        {
            remplirdata();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            PL.FRM_AjoutCat fRM_AjoutCat = new PL.FRM_AjoutCat(this);
            fRM_AjoutCat.ShowDialog();

        }

        private void btnSuppCat_Click(object sender, EventArgs e)
        {
            {
                BL.CLS_categorie cLS_Categorie = new BL.CLS_categorie();
                int select = 0;
                for (int i = 0; i < dgvCat.Rows.Count; i++)
                {
                    if ((bool)dgvCat.Rows[i].Cells[0].Value == true)
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
                    MessageBox.Show("Voulez-vous supprimer la catégorie ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R == DialogResult.Yes)
                    {
                        //Supprime toutes les lignes sélectionnées
                        for (int i = 0; i < dgvCat.Rows.Count; i++)
                        {
                            if ((bool)dgvCat.Rows[i].Cells[0].Value == true)
                            {
                                cLS_Categorie.Supp_Cat(int.Parse(dgvCat.Rows[i].Cells[1].Value.ToString()));
                            }

                        }
                        //actualiser datagrid
                        remplirdata();
                        MessageBox.Show("Catégorie supprimée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Suppression annulée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
