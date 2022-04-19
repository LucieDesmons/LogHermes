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
    public partial class FRM_Client_Commande : Form
    {
        private dbStockContext db; 
        public FRM_Client_Commande()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        private void FRM_Client_Commande_Load(object sender, EventArgs e)
        {
            // remplir liste des clients
            foreach(var c in db.CLIENT)
            {
                dgvClient.Rows.Add(c.Id_Client,c.Nom_Client,c.Prenom_Client,c.Adresse_Client,c.Ville_Client,c.Pays_Client, c.Telephone_Client,c.Email_Client);

            }
        }

        private void dgvClient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
    }
}
