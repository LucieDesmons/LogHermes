namespace GestionStock.Stock.PL
{
    partial class USR_Categorie
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
            this.dgvCat = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.comboRech = new System.Windows.Forms.ComboBox();
            this.btnSuppCat = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.btnImprCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCat
            // 
            this.dgvCat.AllowUserToAddRows = false;
            this.dgvCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column1});
            this.dgvCat.Location = new System.Drawing.Point(65, 225);
            this.dgvCat.Name = "dgvCat";
            this.dgvCat.RowHeadersVisible = false;
            this.dgvCat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCat.RowTemplate.Height = 24;
            this.dgvCat.Size = new System.Drawing.Size(885, 347);
            this.dgvCat.TabIndex = 13;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Select";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Catégorie";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 400;
            // 
            // textBoxR
            // 
            this.textBoxR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxR.Location = new System.Drawing.Point(551, 158);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(286, 32);
            this.textBoxR.TabIndex = 12;
            this.textBoxR.Text = "Rechercher...";
            this.textBoxR.TextChanged += new System.EventHandler(this.textBoxR_TextChanged);
            // 
            // comboRech
            // 
            this.comboRech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRech.FormattingEnabled = true;
            this.comboRech.Items.AddRange(new object[] {
            "Nom Catégorie",
            "Id"});
            this.comboRech.Location = new System.Drawing.Point(134, 158);
            this.comboRech.Name = "comboRech";
            this.comboRech.Size = new System.Drawing.Size(311, 32);
            this.comboRech.TabIndex = 11;
            // 
            // btnSuppCat
            // 
            this.btnSuppCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuppCat.Location = new System.Drawing.Point(401, 37);
            this.btnSuppCat.Name = "btnSuppCat";
            this.btnSuppCat.Size = new System.Drawing.Size(176, 57);
            this.btnSuppCat.TabIndex = 10;
            this.btnSuppCat.Text = "Supprimer";
            this.btnSuppCat.UseVisualStyleBackColor = true;
            this.btnSuppCat.Click += new System.EventHandler(this.btnSuppCat_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(134, 37);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(176, 57);
            this.btnAddCat.TabIndex = 8;
            this.btnAddCat.Text = "Ajouter";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // btnImprCat
            // 
            this.btnImprCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprCat.Location = new System.Drawing.Point(661, 37);
            this.btnImprCat.Name = "btnImprCat";
            this.btnImprCat.Size = new System.Drawing.Size(176, 57);
            this.btnImprCat.TabIndex = 14;
            this.btnImprCat.Text = "Imprimer";
            this.btnImprCat.UseVisualStyleBackColor = true;
            // 
            // USR_Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnImprCat);
            this.Controls.Add(this.dgvCat);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.comboRech);
            this.Controls.Add(this.btnSuppCat);
            this.Controls.Add(this.btnAddCat);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "USR_Categorie";
            this.Size = new System.Drawing.Size(1013, 671);
            this.Load += new System.EventHandler(this.USR_Categorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridView dgvCat;
        public System.Windows.Forms.TextBox textBoxR;
        public System.Windows.Forms.ComboBox comboRech;
        public System.Windows.Forms.Button btnSuppCat;
        public System.Windows.Forms.Button btnAddCat;
        public System.Windows.Forms.Button btnImprCat;
    }
}
