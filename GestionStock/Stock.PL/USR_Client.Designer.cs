namespace GestionStock.Stock.PL
{
    partial class USR_Client
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
            this.components = new System.ComponentModel.Container();
            this.comboRech = new System.Windows.Forms.ComboBox();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESTION_STOCKDataSet = new GestionStock.GESTION_STOCKDataSet();
            this.cLIENTTableAdapter = new GestionStock.GESTION_STOCKDataSetTableAdapters.CLIENTTableAdapter();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSuppClient = new System.Windows.Forms.Button();
            this.btnModClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_STOCKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // comboRech
            // 
            this.comboRech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboRech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRech.FormattingEnabled = true;
            this.comboRech.Items.AddRange(new object[] {
            "Nom",
            "Prénom",
            "Adresse",
            "Telephone",
            "Email",
            "Ville",
            "Pays"});
            this.comboRech.Location = new System.Drawing.Point(422, 142);
            this.comboRech.Name = "comboRech";
            this.comboRech.Size = new System.Drawing.Size(216, 32);
            this.comboRech.TabIndex = 4;
            this.comboRech.SelectedIndexChanged += new System.EventHandler(this.comboRech_SelectedIndexChanged);
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.gESTION_STOCKDataSet;
            // 
            // gESTION_STOCKDataSet
            // 
            this.gESTION_STOCKDataSet.DataSetName = "GESTION_STOCKDataSet";
            this.gESTION_STOCKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxR
            // 
            this.textBoxR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxR.Location = new System.Drawing.Point(665, 142);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(246, 32);
            this.textBoxR.TabIndex = 6;
            this.textBoxR.Text = "Rechercher...";
            this.textBoxR.TextChanged += new System.EventHandler(this.textBoxR_TextChanged);
            this.textBoxR.Enter += new System.EventHandler(this.textBoxR_Enter);
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvClient.Location = new System.Drawing.Point(21, 191);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvClient.RowTemplate.Height = 24;
            this.dgvClient.Size = new System.Drawing.Size(890, 271);
            this.dgvClient.TabIndex = 7;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prénom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Adresse";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ville";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Pays";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Telephone";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Email";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 50F;
            this.Column8.HeaderText = "Select";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnSuppClient
            // 
            this.btnSuppClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuppClient.BackColor = System.Drawing.SystemColors.Control;
            this.btnSuppClient.FlatAppearance.BorderSize = 0;
            this.btnSuppClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppClient.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppClient.Image = global::GestionStock.Properties.Resources.user_business_close_32;
            this.btnSuppClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppClient.Location = new System.Drawing.Point(345, 58);
            this.btnSuppClient.Name = "btnSuppClient";
            this.btnSuppClient.Size = new System.Drawing.Size(137, 43);
            this.btnSuppClient.TabIndex = 2;
            this.btnSuppClient.Text = "Supprimer";
            this.btnSuppClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuppClient.UseVisualStyleBackColor = false;
            this.btnSuppClient.Click += new System.EventHandler(this.btnSuppClient_Click);
            // 
            // btnModClient
            // 
            this.btnModClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModClient.BackColor = System.Drawing.SystemColors.Control;
            this.btnModClient.FlatAppearance.BorderSize = 0;
            this.btnModClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModClient.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModClient.Image = global::GestionStock.Properties.Resources.user_business_info_32;
            this.btnModClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModClient.Location = new System.Drawing.Point(558, 58);
            this.btnModClient.Name = "btnModClient";
            this.btnModClient.Size = new System.Drawing.Size(125, 43);
            this.btnModClient.TabIndex = 1;
            this.btnModClient.Text = "Modifier";
            this.btnModClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModClient.UseVisualStyleBackColor = false;
            this.btnModClient.Click += new System.EventHandler(this.btnModClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.Black;
            this.btnAddClient.Image = global::GestionStock.Properties.Resources.user_business_add_32;
            this.btnAddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClient.Location = new System.Drawing.Point(154, 58);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(121, 43);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Ajouter";
            this.btnAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(21, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 4);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Location = new System.Drawing.Point(21, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 4);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Liste des clients";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Location = new System.Drawing.Point(21, 486);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(890, 4);
            this.panel3.TabIndex = 12;
            // 
            // USR_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.comboRech);
            this.Controls.Add(this.btnSuppClient);
            this.Controls.Add(this.btnModClient);
            this.Controls.Add(this.btnAddClient);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "USR_Client";
            this.Size = new System.Drawing.Size(930, 515);
            this.Load += new System.EventHandler(this.USR_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_STOCKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnModClient;
        private System.Windows.Forms.Button btnSuppClient;
        private System.Windows.Forms.TextBox textBoxRech;
        private System.Windows.Forms.ComboBox comboRech;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private GESTION_STOCKDataSet gESTION_STOCKDataSet;
        private GESTION_STOCKDataSetTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
    }
}
