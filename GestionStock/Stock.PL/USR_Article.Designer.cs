namespace GestionStock.Stock.PL
{
    partial class USR_Article
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
            this.dgvProduit = new System.Windows.Forms.DataGridView();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.comboRech = new System.Windows.Forms.ComboBox();
            this.btnSuppArt = new System.Windows.Forms.Button();
            this.btnModArt = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.btnImpr = new System.Windows.Forms.Button();
            this.btnImprAll = new System.Windows.Forms.Button();
            this.btnExportXls = new System.Windows.Forms.Button();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduit
            // 
            this.dgvProduit.AllowUserToAddRows = false;
            this.dgvProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvProduit.Location = new System.Drawing.Point(132, 236);
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.RowHeadersVisible = false;
            this.dgvProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvProduit.RowTemplate.Height = 24;
            this.dgvProduit.Size = new System.Drawing.Size(1191, 587);
            this.dgvProduit.TabIndex = 13;
            // 
            // textBoxR
            // 
            this.textBoxR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxR.Location = new System.Drawing.Point(1148, 149);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(396, 32);
            this.textBoxR.TabIndex = 12;
            this.textBoxR.Text = "Rechercher...";
            this.textBoxR.TextChanged += new System.EventHandler(this.textBoxR_TextChanged);
            // 
            // comboRech
            // 
            this.comboRech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboRech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRech.FormattingEnabled = true;
            this.comboRech.Items.AddRange(new object[] {
            "Nom",
            "Prix",
            "Catégorie"});
            this.comboRech.Location = new System.Drawing.Point(792, 149);
            this.comboRech.Name = "comboRech";
            this.comboRech.Size = new System.Drawing.Size(304, 32);
            this.comboRech.TabIndex = 11;
            // 
            // btnSuppArt
            // 
            this.btnSuppArt.Location = new System.Drawing.Point(50, 124);
            this.btnSuppArt.Name = "btnSuppArt";
            this.btnSuppArt.Size = new System.Drawing.Size(176, 57);
            this.btnSuppArt.TabIndex = 10;
            this.btnSuppArt.Text = "Supprimer";
            this.btnSuppArt.UseVisualStyleBackColor = true;
            this.btnSuppArt.Click += new System.EventHandler(this.btnSuppArt_Click);
            // 
            // btnModArt
            // 
            this.btnModArt.Location = new System.Drawing.Point(295, 36);
            this.btnModArt.Name = "btnModArt";
            this.btnModArt.Size = new System.Drawing.Size(176, 57);
            this.btnModArt.TabIndex = 9;
            this.btnModArt.Text = "Modifier";
            this.btnModArt.UseVisualStyleBackColor = true;
            this.btnModArt.Click += new System.EventHandler(this.btnModArt_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(50, 36);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(176, 57);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Ajouter";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(295, 124);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(176, 57);
            this.btnPicture.TabIndex = 14;
            this.btnPicture.Text = "Afficher photo";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // btnImpr
            // 
            this.btnImpr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImpr.Location = new System.Drawing.Point(845, 36);
            this.btnImpr.Name = "btnImpr";
            this.btnImpr.Size = new System.Drawing.Size(176, 31);
            this.btnImpr.TabIndex = 17;
            this.btnImpr.Text = "Imprimer";
            this.btnImpr.UseVisualStyleBackColor = true;
            this.btnImpr.Click += new System.EventHandler(this.btnImpr_Click);
            // 
            // btnImprAll
            // 
            this.btnImprAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprAll.Location = new System.Drawing.Point(1098, 36);
            this.btnImprAll.Name = "btnImprAll";
            this.btnImprAll.Size = new System.Drawing.Size(176, 31);
            this.btnImprAll.TabIndex = 18;
            this.btnImprAll.Text = "Impr Catalogue";
            this.btnImprAll.UseVisualStyleBackColor = true;
            this.btnImprAll.Click += new System.EventHandler(this.btnImprAll_Click);
            // 
            // btnExportXls
            // 
            this.btnExportXls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportXls.Location = new System.Drawing.Point(1368, 36);
            this.btnExportXls.Name = "btnExportXls";
            this.btnExportXls.Size = new System.Drawing.Size(176, 31);
            this.btnExportXls.TabIndex = 19;
            this.btnExportXls.Text = "Vers Excel";
            this.btnExportXls.UseVisualStyleBackColor = true;
            this.btnExportXls.Click += new System.EventHandler(this.btnExportXls_Click);
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
            this.Column1.HeaderText = "Nom";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantité";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prix";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Catégorie";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // USR_Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExportXls);
            this.Controls.Add(this.btnImprAll);
            this.Controls.Add(this.btnImpr);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.dgvProduit);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.comboRech);
            this.Controls.Add(this.btnSuppArt);
            this.Controls.Add(this.btnModArt);
            this.Controls.Add(this.btnAddProduct);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "USR_Article";
            this.Size = new System.Drawing.Size(1749, 876);
            this.Load += new System.EventHandler(this.USR_Article_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduit;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.ComboBox comboRech;
        private System.Windows.Forms.Button btnSuppArt;
        private System.Windows.Forms.Button btnModArt;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Button btnImpr;
        private System.Windows.Forms.Button btnImprAll;
        private System.Windows.Forms.Button btnExportXls;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
