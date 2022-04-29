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
    public partial class USR_User : UserControl
    {
        private static USR_User UserUser;
        private dbStockContext db;
        //création d'une instance pour le usercontrol
        public static USR_User Instance
        {
            get
            {
                if (UserUser == null)
                {
                    UserUser = new USR_User();
                }
                return UserUser;
            }

        }
        public USR_User()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        public void remplirdata()
        {
            db = new dbStockContext();
            dgvUser.Rows.Clear();
            foreach (var user in db.UTILISATEUR)
            {
                dgvUser.Rows.Add(false, user.Nom_Utilisateur, user.Mot_de_passe);
            }
        }
        private void USR_User_Load(object sender, EventArgs e)
        {
            remplirdata();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            PL.FRM_User fRM_AjoutUser = new PL.FRM_User(this);
            fRM_AjoutUser.ShowDialog();
        }

        private void btnSuppUser_Click(object sender, EventArgs e)
        {
            {
                BL.CLS_User cLS_User = new BL.CLS_User();
                int select = 0;
                for (int i = 0; i < dgvUser.Rows.Count; i++)
                {
                    if ((bool)dgvUser.Rows[i].Cells[0].Value == true)
                    {
                        select++;
                    }
                }
                if (select == 0)
                {
                    MessageBox.Show("Aucun utilisateur sélectionné", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult R =
                    MessageBox.Show("Voulez-vous supprimer l'utilisateur ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R == DialogResult.Yes)
                    {
                        //Supprime toutes les lignes sélectionnées
                        for (int i = 0; i < dgvUser.Rows.Count; i++)
                        {
                            if ((bool)dgvUser.Rows[i].Cells[0].Value == true)
                            {
                                cLS_User.SuppUser((dgvUser.Rows[i].Cells[1].Value.ToString()));
                            }

                        }
                        //actualiser datagrid
                        remplirdata();
                        MessageBox.Show("Nom supprimée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
