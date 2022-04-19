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
        }

        private void btnAddCmde_Click(object sender, EventArgs e)
        {
            PL.FRM_Commande fRM_Commande = new PL.FRM_Commande();
            fRM_Commande.ShowDialog();
        }
    }
}
