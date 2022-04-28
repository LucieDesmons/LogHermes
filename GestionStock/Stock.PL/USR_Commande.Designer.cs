namespace GestionStock.Stock.PL
{
    partial class USR_Commande
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCmde = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImpr = new System.Windows.Forms.Button();
            this.btnRechCmde = new System.Windows.Forms.Button();
            this.btnAddCmde = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCmde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmde)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCmde
            // 
            this.dgvCmde.AllowUserToAddRows = false;
            this.dgvCmde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCmde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCmde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvCmde.Location = new System.Drawing.Point(28, 265);
            this.dgvCmde.Name = "dgvCmde";
            this.dgvCmde.RowHeadersVisible = false;
            this.dgvCmde.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCmde.RowTemplate.Height = 24;
            this.dgvCmde.Size = new System.Drawing.Size(1340, 395);
            this.dgvCmde.TabIndex = 13;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Client";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total HT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TVA";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TOTAL TTC";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dateDebut
            // 
            this.dateDebut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDebut.Location = new System.Drawing.Point(851, 103);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(298, 32);
            this.dateDebut.TabIndex = 14;
            // 
            // dateFin
            // 
            this.dateFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFin.Location = new System.Drawing.Point(851, 141);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(298, 32);
            this.dateFin.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(716, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date début :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(716, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Date de fin :";
            // 
            // btnImpr
            // 
            this.btnImpr.Image = global::GestionStock.Properties.Resources.print32;
            this.btnImpr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpr.Location = new System.Drawing.Point(271, 103);
            this.btnImpr.Name = "btnImpr";
            this.btnImpr.Size = new System.Drawing.Size(154, 51);
            this.btnImpr.TabIndex = 18;
            this.btnImpr.Text = "Imprimer";
            this.btnImpr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImpr.UseVisualStyleBackColor = true;
            this.btnImpr.Click += new System.EventHandler(this.btnImpr_Click);
            // 
            // btnRechCmde
            // 
            this.btnRechCmde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRechCmde.Image = global::GestionStock.Properties.Resources.search_32;
            this.btnRechCmde.Location = new System.Drawing.Point(611, 109);
            this.btnRechCmde.Name = "btnRechCmde";
            this.btnRechCmde.Size = new System.Drawing.Size(53, 45);
            this.btnRechCmde.TabIndex = 10;
            this.btnRechCmde.UseVisualStyleBackColor = true;
            this.btnRechCmde.Click += new System.EventHandler(this.btnRechCmde_Click);
            // 
            // btnAddCmde
            // 
            this.btnAddCmde.Image = global::GestionStock.Properties.Resources.book_add_32;
            this.btnAddCmde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCmde.Location = new System.Drawing.Point(28, 103);
            this.btnAddCmde.Name = "btnAddCmde";
            this.btnAddCmde.Size = new System.Drawing.Size(141, 51);
            this.btnAddCmde.TabIndex = 8;
            this.btnAddCmde.Text = "Ajouter";
            this.btnAddCmde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCmde.UseVisualStyleBackColor = true;
            this.btnAddCmde.Click += new System.EventHandler(this.btnAddCmde_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(28, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 10);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Location = new System.Drawing.Point(28, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1337, 10);
            this.panel2.TabIndex = 20;
            // 
            // lblCmde
            // 
            this.lblCmde.AutoSize = true;
            this.lblCmde.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmde.ForeColor = System.Drawing.Color.Transparent;
            this.lblCmde.Location = new System.Drawing.Point(31, 21);
            this.lblCmde.Name = "lblCmde";
            this.lblCmde.Size = new System.Drawing.Size(310, 35);
            this.lblCmde.TabIndex = 21;
            this.lblCmde.Text = "Catalogue Commande";
            // 
            // USR_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCmde);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImpr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.dateDebut);
            this.Controls.Add(this.dgvCmde);
            this.Controls.Add(this.btnRechCmde);
            this.Controls.Add(this.btnAddCmde);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "USR_Commande";
            this.Size = new System.Drawing.Size(1400, 700);
            this.Load += new System.EventHandler(this.USR_Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCmde;
        private System.Windows.Forms.Button btnRechCmde;
        private System.Windows.Forms.Button btnAddCmde;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCmde;
    }
}
