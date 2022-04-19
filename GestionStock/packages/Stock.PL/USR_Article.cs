using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock.Stock.PL
{
    public partial class USR_Article : UserControl
    {
        private static USR_Article UserArticle;
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
        }



        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text =="Recherche...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void btnNewArticle_Click(object sender, EventArgs e)
        {
            //Affiche le formulaire de création de client
            PL.FRM_Add_Article frmArticle = new PL.FRM_Add_Article();
            frmArticle.ShowDialog();
        }
    }
}
