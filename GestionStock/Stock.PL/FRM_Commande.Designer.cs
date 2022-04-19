namespace GestionStock.Stock.PL
{
    partial class FRM_Commande
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
            this.components = new System.ComponentModel.Container();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnValidClt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFicheCmde = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textPays = new System.Windows.Forms.TextBox();
            this.textVille = new System.Windows.Forms.TextBox();
            this.textAdresse = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCommande = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gESTION_STOCKDataSet1 = new GestionStock.GESTION_STOCKDataSet1();
            this.detailsCommandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.details_CommandeTableAdapter = new GestionStock.GESTION_STOCKDataSet1TableAdapters.Details_CommandeTableAdapter();
            this.lblTHT = new System.Windows.Forms.Label();
            this.lblTVA = new System.Windows.Forms.Label();
            this.lblTTTC = new System.Windows.Forms.Label();
            this.txtTHT = new System.Windows.Forms.TextBox();
            this.txtTVA = new System.Windows.Forms.TextBox();
            this.txtTTTC = new System.Windows.Forms.TextBox();
            this.txtBoxR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProduit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnClt = new System.Windows.Forms.Button();
            this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_STOCKDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsCommandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAnnuler.Location = new System.Drawing.Point(375, 574);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(122, 43);
            this.btnAnnuler.TabIndex = 68;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(52, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 10);
            this.panel2.TabIndex = 67;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Firebrick;
            this.btnQuit.Location = new System.Drawing.Point(594, 574);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(122, 43);
            this.btnQuit.TabIndex = 66;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnValidClt
            // 
            this.btnValidClt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnValidClt.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnValidClt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnValidClt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnValidClt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidClt.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidClt.ForeColor = System.Drawing.Color.Firebrick;
            this.btnValidClt.Location = new System.Drawing.Point(155, 574);
            this.btnValidClt.Name = "btnValidClt";
            this.btnValidClt.Size = new System.Drawing.Size(122, 43);
            this.btnValidClt.TabIndex = 65;
            this.btnValidClt.Text = "Valider";
            this.btnValidClt.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblFicheCmde);
            this.panel1.Location = new System.Drawing.Point(39, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 66);
            this.panel1.TabIndex = 64;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(531, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(304, 32);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblFicheCmde
            // 
            this.lblFicheCmde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFicheCmde.AutoSize = true;
            this.lblFicheCmde.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFicheCmde.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblFicheCmde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFicheCmde.Location = new System.Drawing.Point(234, 17);
            this.lblFicheCmde.Name = "lblFicheCmde";
            this.lblFicheCmde.Size = new System.Drawing.Size(212, 28);
            this.lblFicheCmde.TabIndex = 0;
            this.lblFicheCmde.Text = "Fiche Commande du";
            // 
            // textTel
            // 
            this.textTel.Enabled = false;
            this.textTel.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTel.ForeColor = System.Drawing.Color.Silver;
            this.textTel.Location = new System.Drawing.Point(535, 244);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(225, 28);
            this.textTel.TabIndex = 63;
            this.textTel.Text = "Téléphone";
            // 
            // textMail
            // 
            this.textMail.Enabled = false;
            this.textMail.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMail.ForeColor = System.Drawing.Color.Silver;
            this.textMail.Location = new System.Drawing.Point(155, 241);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(225, 28);
            this.textMail.TabIndex = 62;
            this.textMail.Text = "Mail";
            // 
            // textPays
            // 
            this.textPays.Enabled = false;
            this.textPays.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPays.ForeColor = System.Drawing.Color.Silver;
            this.textPays.Location = new System.Drawing.Point(594, 204);
            this.textPays.Name = "textPays";
            this.textPays.Size = new System.Drawing.Size(166, 28);
            this.textPays.TabIndex = 61;
            this.textPays.Text = "Pays";
            // 
            // textVille
            // 
            this.textVille.Enabled = false;
            this.textVille.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVille.ForeColor = System.Drawing.Color.Silver;
            this.textVille.Location = new System.Drawing.Point(320, 200);
            this.textVille.Name = "textVille";
            this.textVille.Size = new System.Drawing.Size(197, 28);
            this.textVille.TabIndex = 60;
            this.textVille.Text = "Ville";
            // 
            // textAdresse
            // 
            this.textAdresse.Enabled = false;
            this.textAdresse.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAdresse.ForeColor = System.Drawing.Color.Silver;
            this.textAdresse.Location = new System.Drawing.Point(155, 162);
            this.textAdresse.Name = "textAdresse";
            this.textAdresse.Size = new System.Drawing.Size(605, 28);
            this.textAdresse.TabIndex = 59;
            this.textAdresse.Text = "Adresse client";
            // 
            // textPrenom
            // 
            this.textPrenom.Enabled = false;
            this.textPrenom.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrenom.ForeColor = System.Drawing.Color.Silver;
            this.textPrenom.Location = new System.Drawing.Point(535, 122);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(225, 28);
            this.textPrenom.TabIndex = 58;
            this.textPrenom.Text = "Prénom client";
            // 
            // textNom
            // 
            this.textNom.Enabled = false;
            this.textNom.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNom.ForeColor = System.Drawing.Color.Silver;
            this.textNom.Location = new System.Drawing.Point(155, 122);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(225, 28);
            this.textNom.TabIndex = 57;
            this.textNom.Text = "Nom de client";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(437, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 56;
            this.label8.Text = "Téléphone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(84, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 55;
            this.label7.Text = "Email*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(531, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 54;
            this.label6.Text = "Pays*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(254, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "Ville*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(84, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(437, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Prénom*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(85, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nom*";
            // 
            // dgvCommande
            // 
            this.dgvCommande.AllowUserToAddRows = false;
            this.dgvCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvCommande.ContextMenuStrip = this.contextMenuStrip;
            this.dgvCommande.Location = new System.Drawing.Point(52, 314);
            this.dgvCommande.Name = "dgvCommande";
            this.dgvCommande.ReadOnly = true;
            this.dgvCommande.RowHeadersVisible = false;
            this.dgvCommande.RowHeadersWidth = 51;
            this.dgvCommande.RowTemplate.Height = 24;
            this.dgvCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommande.Size = new System.Drawing.Size(778, 165);
            this.dgvCommande.TabIndex = 69;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Produit";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom Produit";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Remise";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // gESTION_STOCKDataSet1
            // 
            this.gESTION_STOCKDataSet1.DataSetName = "GESTION_STOCKDataSet1";
            this.gESTION_STOCKDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailsCommandeBindingSource
            // 
            this.detailsCommandeBindingSource.DataMember = "Details_Commande";
            this.detailsCommandeBindingSource.DataSource = this.gESTION_STOCKDataSet1;
            // 
            // details_CommandeTableAdapter
            // 
            this.details_CommandeTableAdapter.ClearBeforeFill = true;
            // 
            // lblTHT
            // 
            this.lblTHT.AutoSize = true;
            this.lblTHT.Location = new System.Drawing.Point(77, 506);
            this.lblTHT.Name = "lblTHT";
            this.lblTHT.Size = new System.Drawing.Size(88, 24);
            this.lblTHT.TabIndex = 70;
            this.lblTHT.Text = "Total HT :";
            // 
            // lblTVA
            // 
            this.lblTVA.AutoSize = true;
            this.lblTVA.Location = new System.Drawing.Point(316, 506);
            this.lblTVA.Name = "lblTVA";
            this.lblTVA.Size = new System.Drawing.Size(52, 24);
            this.lblTVA.TabIndex = 71;
            this.lblTVA.Text = "TVA :";
            // 
            // lblTTTC
            // 
            this.lblTTTC.AutoSize = true;
            this.lblTTTC.Location = new System.Drawing.Point(490, 506);
            this.lblTTTC.Name = "lblTTTC";
            this.lblTTTC.Size = new System.Drawing.Size(110, 24);
            this.lblTTTC.TabIndex = 72;
            this.lblTTTC.Text = "TOTAL TTC :";
            // 
            // txtTHT
            // 
            this.txtTHT.Enabled = false;
            this.txtTHT.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTHT.ForeColor = System.Drawing.Color.Silver;
            this.txtTHT.Location = new System.Drawing.Point(169, 506);
            this.txtTHT.Name = "txtTHT";
            this.txtTHT.Size = new System.Drawing.Size(108, 28);
            this.txtTHT.TabIndex = 73;
            // 
            // txtTVA
            // 
            this.txtTVA.Enabled = false;
            this.txtTVA.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTVA.ForeColor = System.Drawing.Color.Silver;
            this.txtTVA.Location = new System.Drawing.Point(375, 506);
            this.txtTVA.Name = "txtTVA";
            this.txtTVA.Size = new System.Drawing.Size(60, 28);
            this.txtTVA.TabIndex = 74;
            this.txtTVA.TextChanged += new System.EventHandler(this.txtTVA_TextChanged);
            // 
            // txtTTTC
            // 
            this.txtTTTC.Enabled = false;
            this.txtTTTC.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTTC.ForeColor = System.Drawing.Color.Silver;
            this.txtTTTC.Location = new System.Drawing.Point(605, 506);
            this.txtTTTC.Name = "txtTTTC";
            this.txtTTTC.Size = new System.Drawing.Size(155, 28);
            this.txtTTTC.TabIndex = 75;
            // 
            // txtBoxR
            // 
            this.txtBoxR.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxR.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxR.Location = new System.Drawing.Point(1076, 122);
            this.txtBoxR.Name = "txtBoxR";
            this.txtBoxR.Size = new System.Drawing.Size(291, 28);
            this.txtBoxR.TabIndex = 76;
            this.txtBoxR.Text = "Recherche...";
            this.txtBoxR.TextChanged += new System.EventHandler(this.txtBoxR_TextChanged);
            this.txtBoxR.Enter += new System.EventHandler(this.txtBoxR_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(974, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 77;
            this.label4.Text = "Recherche :";
            // 
            // dgvProduit
            // 
            this.dgvProduit.AllowUserToAddRows = false;
            this.dgvProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvProduit.Location = new System.Drawing.Point(908, 186);
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.ReadOnly = true;
            this.dgvProduit.RowHeadersVisible = false;
            this.dgvProduit.RowHeadersWidth = 51;
            this.dgvProduit.RowTemplate.Height = 24;
            this.dgvProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduit.Size = new System.Drawing.Size(485, 392);
            this.dgvProduit.TabIndex = 78;
            this.dgvProduit.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduit_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Produit";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantité";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(864, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 494);
            this.panel3.TabIndex = 68;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem1,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip2";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip.Size = new System.Drawing.Size(152, 56);
            // 
            // btnClt
            // 
            this.btnClt.BackColor = System.Drawing.Color.Transparent;
            this.btnClt.FlatAppearance.BorderSize = 0;
            this.btnClt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClt.ForeColor = System.Drawing.Color.Transparent;
            this.btnClt.Image = global::GestionStock.Properties.Resources.add1;
            this.btnClt.Location = new System.Drawing.Point(39, 115);
            this.btnClt.Name = "btnClt";
            this.btnClt.Size = new System.Drawing.Size(40, 38);
            this.btnClt.TabIndex = 79;
            this.btnClt.UseVisualStyleBackColor = false;
            this.btnClt.Click += new System.EventHandler(this.btnClt_Click);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.Image = global::GestionStock.Properties.Resources.refresh1;
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(214, 26);
            this.modifierToolStripMenuItem1.Text = "Modifier";
            this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.modifierToolStripMenuItem1_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Image = global::GestionStock.Properties.Resources.Recycle1;
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // FRM_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 665);
            this.Controls.Add(this.btnClt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvProduit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxR);
            this.Controls.Add(this.txtTTTC);
            this.Controls.Add(this.txtTVA);
            this.Controls.Add(this.txtTHT);
            this.Controls.Add(this.lblTTTC);
            this.Controls.Add(this.lblTVA);
            this.Controls.Add(this.lblTHT);
            this.Controls.Add(this.dgvCommande);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnValidClt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.textPays);
            this.Controls.Add(this.textVille);
            this.Controls.Add(this.textAdresse);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Commande";
            this.Load += new System.EventHandler(this.FRM_Commande_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_STOCKDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsCommandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnQuit;
        public System.Windows.Forms.Button btnValidClt;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblFicheCmde;
        public System.Windows.Forms.TextBox textTel;
        public System.Windows.Forms.TextBox textMail;
        public System.Windows.Forms.TextBox textPays;
        public System.Windows.Forms.TextBox textVille;
        public System.Windows.Forms.TextBox textAdresse;
        public System.Windows.Forms.TextBox textPrenom;
        public System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private GESTION_STOCKDataSet1 gESTION_STOCKDataSet1;
        private System.Windows.Forms.BindingSource detailsCommandeBindingSource;
        private GESTION_STOCKDataSet1TableAdapters.Details_CommandeTableAdapter details_CommandeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lblTHT;
        private System.Windows.Forms.Label lblTVA;
        private System.Windows.Forms.Label lblTTTC;
        public System.Windows.Forms.TextBox txtTHT;
        public System.Windows.Forms.TextBox txtTVA;
        public System.Windows.Forms.TextBox txtTTTC;
        public System.Windows.Forms.TextBox txtBoxR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgvCommande;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip;
    }
}