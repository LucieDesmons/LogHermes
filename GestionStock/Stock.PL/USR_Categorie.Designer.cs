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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCat = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.comboRech = new System.Windows.Forms.ComboBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSuppCat = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCat
            // 
            this.dgvCat.AllowUserToAddRows = false;
            this.dgvCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dgvCat.Size = new System.Drawing.Size(656, 347);
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
            this.textBoxR.Location = new System.Drawing.Point(435, 158);
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
            this.comboRech.Location = new System.Drawing.Point(65, 158);
            this.comboRech.Name = "comboRech";
            this.comboRech.Size = new System.Drawing.Size(311, 32);
            this.comboRech.TabIndex = 11;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.ForeColor = System.Drawing.Color.Transparent;
            this.lblCat.Location = new System.Drawing.Point(59, 17);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(279, 35);
            this.lblCat.TabIndex = 14;
            this.lblCat.Text = "Catalogue catégorie";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(26, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 8);
            this.panel1.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightCoral;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 142);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(736, 8);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // btnSuppCat
            // 
            this.btnSuppCat.Image = global::GestionStock.Properties.Resources.web_layout_error_32_close;
            this.btnSuppCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppCat.Location = new System.Drawing.Point(226, 89);
            this.btnSuppCat.Name = "btnSuppCat";
            this.btnSuppCat.Size = new System.Drawing.Size(150, 35);
            this.btnSuppCat.TabIndex = 10;
            this.btnSuppCat.Text = "Supprimer";
            this.btnSuppCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuppCat.UseVisualStyleBackColor = true;
            this.btnSuppCat.Click += new System.EventHandler(this.btnSuppCat_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Image = global::GestionStock.Properties.Resources.web_layout_error_32_add1;
            this.btnAddCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCat.Location = new System.Drawing.Point(65, 89);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(132, 35);
            this.btnAddCat.TabIndex = 8;
            this.btnAddCat.Text = "Ajouter";
            this.btnAddCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // USR_Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.dgvCat);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.comboRech);
            this.Controls.Add(this.btnSuppCat);
            this.Controls.Add(this.btnAddCat);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "USR_Categorie";
            this.Size = new System.Drawing.Size(784, 671);
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
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
