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
    public partial class USR_Maison : UserControl
    {
        private static USR_Maison UserMaison;
        private dbStockContext db;
        //création d'une instance pour le usercontrol
        public static USR_Maison Instance
        {
            get
            {
                if (UserMaison == null)
                {
                    UserMaison = new USR_Maison();
                }
                return UserMaison;
            }
        }
        public USR_Maison()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        public void remplirdata()
        {
            db = new dbStockContext();
            dgvMais.Rows.Clear();
            foreach (var Mais in db.MAISON)
            {
                dgvMais.Rows.Add(false, Mais.ID_MAISON, Mais.Nom_Maison);
            }
        }

        private void textBoxRe_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRe.Text == "Recherche...")
            {
                textBoxRe.Text = "";
                textBoxRe.ForeColor = Color.Black;
            }
            var maliste = db.MAISON.ToList();
            maliste = maliste.Where(s => s.Nom_Maison.IndexOf(textBoxRe.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            dgvMais.Rows.Clear();
            foreach (var l in maliste)
            {
                dgvMais.Rows.Add(false, l.ID_MAISON, l.Nom_Maison);
            }
        }
        private void USR_Maison_Load(object sender, EventArgs e)
        {
            remplirdata();
        }

        private void btnAddMais_Click(object sender, EventArgs e)
        {
            PL.FRM_Maison fRM_Maison = new PL.FRM_Maison(this);
            fRM_Maison.ShowDialog();
        }



        private void btnSuppMais_Click(object sender, EventArgs e)
        
        {
            BL.CLS_Maison cLS_Maison = new BL.CLS_Maison();
            int select = 0;
            for (int i = 0; i < dgvMais.Rows.Count; i++)
            {
                if ((bool)dgvMais.Rows[i].Cells[0].Value == true)
                {
                    select++;
                }
            }
            if (select == 0)
            {
                MessageBox.Show("Aucune maison sélectionnée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult R =
                MessageBox.Show("Voulez-vous supprimer la maison ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    //Supprime toutes les lignes sélectionnées
                    for (int i = 0; i < dgvMais.Rows.Count; i++)
                    {
                        if ((bool)dgvMais.Rows[i].Cells[0].Value == true)
                        {
                            cLS_Maison.Supp_Mais(int.Parse(dgvMais.Rows[i].Cells[1].Value.ToString()));
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
