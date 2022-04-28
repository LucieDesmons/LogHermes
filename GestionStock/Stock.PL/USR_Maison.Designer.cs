namespace GestionStock.Stock.PL
{
    partial class USR_Maison
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
            this.dgvMais = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxRe = new System.Windows.Forms.TextBox();
            this.comboRech = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMaison = new System.Windows.Forms.Label();
            this.btnSuppMais = new System.Windows.Forms.Button();
            this.btnAddMais = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMais)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMais
            // 
            this.dgvMais.AllowUserToAddRows = false;
            this.dgvMais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column1});
            this.dgvMais.Location = new System.Drawing.Point(40, 242);
            this.dgvMais.Name = "dgvMais";
            this.dgvMais.RowHeadersVisible = false;
            this.dgvMais.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvMais.RowTemplate.Height = 24;
            this.dgvMais.Size = new System.Drawing.Size(645, 347);
            this.dgvMais.TabIndex = 19;
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
            this.Column1.HeaderText = "Maison";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 400;
            // 
            // textBoxRe
            // 
            this.textBoxRe.Location = new System.Drawing.Point(397, 175);
            this.textBoxRe.Name = "textBoxRe";
            this.textBoxRe.Size = new System.Drawing.Size(286, 32);
            this.textBoxRe.TabIndex = 18;
            this.textBoxRe.Text = "Rechercher...";
            this.textBoxRe.TextChanged += new System.EventHandler(this.textBoxRe_TextChanged);
            // 
            // comboRech
            // 
            this.comboRech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRech.FormattingEnabled = true;
            this.comboRech.Items.AddRange(new object[] {
            "Nom maison",
            "Id"});
            this.comboRech.Location = new System.Drawing.Point(40, 175);
            this.comboRech.Name = "comboRech";
            this.comboRech.Size = new System.Drawing.Size(290, 32);
            this.comboRech.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(40, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 8);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Location = new System.Drawing.Point(40, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 8);
            this.panel2.TabIndex = 21;
            // 
            // lblMaison
            // 
            this.lblMaison.AutoSize = true;
            this.lblMaison.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaison.ForeColor = System.Drawing.Color.Transparent;
            this.lblMaison.Location = new System.Drawing.Point(38, 23);
            this.lblMaison.Name = "lblMaison";
            this.lblMaison.Size = new System.Drawing.Size(254, 35);
            this.lblMaison.TabIndex = 22;
            this.lblMaison.Text = "Catalogue maison";
            // 
            // btnSuppMais
            // 
            this.btnSuppMais.Image = global::GestionStock.Properties.Resources.address_book_close_32;
            this.btnSuppMais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppMais.Location = new System.Drawing.Point(245, 95);
            this.btnSuppMais.Name = "btnSuppMais";
            this.btnSuppMais.Size = new System.Drawing.Size(148, 38);
            this.btnSuppMais.TabIndex = 16;
            this.btnSuppMais.Text = "Supprimer";
            this.btnSuppMais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuppMais.UseVisualStyleBackColor = true;
            this.btnSuppMais.Click += new System.EventHandler(this.btnSuppMais_Click);
            // 
            // btnAddMais
            // 
            this.btnAddMais.Image = global::GestionStock.Properties.Resources.address_book_add_32;
            this.btnAddMais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMais.Location = new System.Drawing.Point(75, 95);
            this.btnAddMais.Name = "btnAddMais";
            this.btnAddMais.Size = new System.Drawing.Size(130, 38);
            this.btnAddMais.TabIndex = 15;
            this.btnAddMais.Text = "Ajouter";
            this.btnAddMais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMais.UseVisualStyleBackColor = true;
            this.btnAddMais.Click += new System.EventHandler(this.btnAddMais_Click);
            // 
            // USR_Maison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMaison);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMais);
            this.Controls.Add(this.textBoxRe);
            this.Controls.Add(this.comboRech);
            this.Controls.Add(this.btnSuppMais);
            this.Controls.Add(this.btnAddMais);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "USR_Maison";
            this.Size = new System.Drawing.Size(702, 643);
            this.Load += new System.EventHandler(this.USR_Maison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvMais;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.TextBox textBoxRe;
        public System.Windows.Forms.ComboBox comboRech;
        public System.Windows.Forms.Button btnSuppMais;
        public System.Windows.Forms.Button btnAddMais;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMaison;
    }
}
