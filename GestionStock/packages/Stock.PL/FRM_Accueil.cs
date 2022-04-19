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
    public partial class FRM_Accueil : Form
    {
        public FRM_Accueil()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            if(!pnlAfficher.Controls.Contains(USR_Article.Instance))
            {
                pnlAfficher.Controls.Add(USR_Article.Instance);
                USR_Article.Instance.Dock = DockStyle.Fill;
                USR_Article.Instance.BringToFront();
            }else
            {
                USR_Article.Instance.BringToFront();
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            //pnlAfficher.Leave();
        }
    }
}
