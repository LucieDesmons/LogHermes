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
    public partial class FRM_Load : Form
    {
        public FRM_Load()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int i;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 2;


            for (i= 0; i < 100; i++)
            {
                progressBar1.Value = i;
                if (progressBar1.Value == progressBar1.Maximum);
                {
                    //this.Stop();
                    FRM_Accueil fa = new FRM_Accueil();
                    fa.Show();

                }
            }
        }
    }
}
