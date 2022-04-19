namespace GestionStock.Report
{
    partial class FRM_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rpAfficher = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpAfficher
            // 
            this.rpAfficher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpAfficher.Location = new System.Drawing.Point(0, 0);
            this.rpAfficher.Name = "rpAfficher";
            this.rpAfficher.ServerReport.BearerToken = null;
            this.rpAfficher.Size = new System.Drawing.Size(984, 674);
            this.rpAfficher.TabIndex = 0;
            // 
            // FRM_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 674);
            this.Controls.Add(this.rpAfficher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapport";
            this.Load += new System.EventHandler(this.FRM_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rpAfficher;
    }
}