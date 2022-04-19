using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock.Report
{
    public partial class FRM_Report : Form
    {
        public FRM_Report()
        {
            InitializeComponent();
        }

        private void FRM_Report_Load(object sender, EventArgs e)
        {

            this.rpAfficher.RefreshReport();
        }
    }
}
