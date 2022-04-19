namespace Stock.Stock.PL
{
    partial class FRM_Accueil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.btnArticle = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnFournisseur = new System.Windows.Forms.Button();
            this.btnCategorie = new System.Windows.Forms.Button();
            this.btnCdeClt = new System.Windows.Forms.Button();
            this.btnCdeFrn = new System.Windows.Forms.Button();
            this.btnEmploye = new System.Windows.Forms.Button();
            this.btnEmpltStock = new System.Windows.Forms.Button();
            this.btnFacture = new System.Windows.Forms.Button();
            this.pnlAfficher = new System.Windows.Forms.Panel();
            this.btnLeave = new System.Windows.Forms.Button();
            this.dvgArticle = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAfficher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuit.Image = global::Stock.Properties.Resources.close1;
            this.btnQuit.Location = new System.Drawing.Point(1273, 12);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(35, 34);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormat.BackColor = System.Drawing.Color.Transparent;
            this.btnFormat.FlatAppearance.BorderSize = 0;
            this.btnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormat.Image = global::Stock.Properties.Resources.arrow_right_up1;
            this.btnFormat.Location = new System.Drawing.Point(1238, 12);
            this.btnFormat.Margin = new System.Windows.Forms.Padding(0);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(35, 34);
            this.btnFormat.TabIndex = 1;
            this.btnFormat.UseCompatibleTextRendering = true;
            this.btnFormat.UseVisualStyleBackColor = false;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnArticle
            // 
            this.btnArticle.BackColor = System.Drawing.Color.Transparent;
            this.btnArticle.FlatAppearance.BorderSize = 0;
            this.btnArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticle.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnArticle.Image = global::Stock.Properties.Resources.window_app_list_add_32;
            this.btnArticle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnArticle.Location = new System.Drawing.Point(12, 13);
            this.btnArticle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArticle.Name = "btnArticle";
            this.btnArticle.Size = new System.Drawing.Size(100, 85);
            this.btnArticle.TabIndex = 2;
            this.btnArticle.Text = "Article";
            this.btnArticle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArticle.UseVisualStyleBackColor = false;
            this.btnArticle.Click += new System.EventHandler(this.btnArticle_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Transparent;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.Firebrick;
            this.btnClient.Image = global::Stock.Properties.Resources.user_business_32;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClient.Location = new System.Drawing.Point(12, 246);
            this.btnClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(100, 85);
            this.btnClient.TabIndex = 3;
            this.btnClient.Text = "Client";
            this.btnClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClient.UseVisualStyleBackColor = false;
            // 
            // btnFournisseur
            // 
            this.btnFournisseur.BackColor = System.Drawing.Color.Transparent;
            this.btnFournisseur.FlatAppearance.BorderSize = 0;
            this.btnFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFournisseur.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFournisseur.ForeColor = System.Drawing.Color.Firebrick;
            this.btnFournisseur.Image = global::Stock.Properties.Resources.users_business_32;
            this.btnFournisseur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFournisseur.Location = new System.Drawing.Point(12, 360);
            this.btnFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFournisseur.Name = "btnFournisseur";
            this.btnFournisseur.Size = new System.Drawing.Size(100, 85);
            this.btnFournisseur.TabIndex = 4;
            this.btnFournisseur.Text = "Fournisseur";
            this.btnFournisseur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFournisseur.UseVisualStyleBackColor = false;
            // 
            // btnCategorie
            // 
            this.btnCategorie.BackColor = System.Drawing.Color.Transparent;
            this.btnCategorie.FlatAppearance.BorderSize = 0;
            this.btnCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorie.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorie.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCategorie.Image = global::Stock.Properties.Resources.book_bookmarks_32;
            this.btnCategorie.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategorie.Location = new System.Drawing.Point(137, 13);
            this.btnCategorie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCategorie.Name = "btnCategorie";
            this.btnCategorie.Size = new System.Drawing.Size(100, 85);
            this.btnCategorie.TabIndex = 5;
            this.btnCategorie.Text = "Catégorie";
            this.btnCategorie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategorie.UseVisualStyleBackColor = false;
            // 
            // btnCdeClt
            // 
            this.btnCdeClt.BackColor = System.Drawing.Color.Transparent;
            this.btnCdeClt.FlatAppearance.BorderSize = 0;
            this.btnCdeClt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCdeClt.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCdeClt.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCdeClt.Image = global::Stock.Properties.Resources.basket_go_32;
            this.btnCdeClt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCdeClt.Location = new System.Drawing.Point(137, 246);
            this.btnCdeClt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCdeClt.Name = "btnCdeClt";
            this.btnCdeClt.Size = new System.Drawing.Size(100, 85);
            this.btnCdeClt.TabIndex = 6;
            this.btnCdeClt.Text = "Commande client";
            this.btnCdeClt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCdeClt.UseVisualStyleBackColor = false;
            // 
            // btnCdeFrn
            // 
            this.btnCdeFrn.BackColor = System.Drawing.Color.Transparent;
            this.btnCdeFrn.FlatAppearance.BorderSize = 0;
            this.btnCdeFrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCdeFrn.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCdeFrn.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCdeFrn.Image = global::Stock.Properties.Resources.basket_back_32;
            this.btnCdeFrn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCdeFrn.Location = new System.Drawing.Point(137, 360);
            this.btnCdeFrn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCdeFrn.Name = "btnCdeFrn";
            this.btnCdeFrn.Size = new System.Drawing.Size(100, 85);
            this.btnCdeFrn.TabIndex = 7;
            this.btnCdeFrn.Text = "Commande fournisseur";
            this.btnCdeFrn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCdeFrn.UseVisualStyleBackColor = false;
            // 
            // btnEmploye
            // 
            this.btnEmploye.BackColor = System.Drawing.Color.Transparent;
            this.btnEmploye.FlatAppearance.BorderSize = 0;
            this.btnEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploye.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploye.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEmploye.Image = global::Stock.Properties.Resources.user_32;
            this.btnEmploye.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmploye.Location = new System.Drawing.Point(1125, 12);
            this.btnEmploye.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmploye.Name = "btnEmploye";
            this.btnEmploye.Size = new System.Drawing.Size(100, 85);
            this.btnEmploye.TabIndex = 8;
            this.btnEmploye.Text = "Utilisateur";
            this.btnEmploye.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmploye.UseVisualStyleBackColor = false;
            // 
            // btnEmpltStock
            // 
            this.btnEmpltStock.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpltStock.FlatAppearance.BorderSize = 0;
            this.btnEmpltStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpltStock.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpltStock.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEmpltStock.Image = global::Stock.Properties.Resources.home_32;
            this.btnEmpltStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmpltStock.Location = new System.Drawing.Point(12, 132);
            this.btnEmpltStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpltStock.Name = "btnEmpltStock";
            this.btnEmpltStock.Size = new System.Drawing.Size(100, 85);
            this.btnEmpltStock.TabIndex = 9;
            this.btnEmpltStock.Text = "Stock";
            this.btnEmpltStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpltStock.UseVisualStyleBackColor = false;
            // 
            // btnFacture
            // 
            this.btnFacture.BackColor = System.Drawing.Color.Transparent;
            this.btnFacture.FlatAppearance.BorderSize = 0;
            this.btnFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacture.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacture.ForeColor = System.Drawing.Color.Firebrick;
            this.btnFacture.Image = global::Stock.Properties.Resources.money_01;
            this.btnFacture.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFacture.Location = new System.Drawing.Point(137, 132);
            this.btnFacture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFacture.Name = "btnFacture";
            this.btnFacture.Size = new System.Drawing.Size(100, 85);
            this.btnFacture.TabIndex = 10;
            this.btnFacture.Text = "Facture";
            this.btnFacture.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFacture.UseVisualStyleBackColor = false;
            // 
            // pnlAfficher
            // 
            this.pnlAfficher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAfficher.AutoSize = true;
            this.pnlAfficher.BackColor = System.Drawing.Color.Transparent;
            this.pnlAfficher.Controls.Add(this.btnLeave);
            this.pnlAfficher.Controls.Add(this.dvgArticle);
            this.pnlAfficher.Location = new System.Drawing.Point(309, 90);
            this.pnlAfficher.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAfficher.Name = "pnlAfficher";
            this.pnlAfficher.Size = new System.Drawing.Size(1015, 636);
            this.pnlAfficher.TabIndex = 11;
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(841, 121);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(75, 23);
            this.btnLeave.TabIndex = 1;
            this.btnLeave.Text = "button1";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            this.btnLeave.Leave += new System.EventHandler(this.btnLeave_Click);
            // 
            // dvgArticle
            // 
            this.dvgArticle.AllowUserToAddRows = false;
            this.dvgArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dvgArticle.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgArticle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dvgArticle.EnableHeadersVisualStyles = false;
            this.dvgArticle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dvgArticle.Location = new System.Drawing.Point(2, 172);
            this.dvgArticle.Margin = new System.Windows.Forms.Padding(4);
            this.dvgArticle.Name = "dvgArticle";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgArticle.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgArticle.RowHeadersVisible = false;
            this.dvgArticle.RowHeadersWidth = 51;
            this.dvgArticle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgArticle.Size = new System.Drawing.Size(962, 289);
            this.dvgArticle.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 61;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 74;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 124;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Note";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 75;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cepage";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 93;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Annee";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 86;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Prix";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 68;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Quantite";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 102;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Categorie";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 110;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Emplacement";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 139;
            // 
            // FRM_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stock.Properties.Resources._10815818;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 734);
            this.Controls.Add(this.btnFacture);
            this.Controls.Add(this.pnlAfficher);
            this.Controls.Add(this.btnEmpltStock);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnEmploye);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCdeFrn);
            this.Controls.Add(this.btnArticle);
            this.Controls.Add(this.btnCdeClt);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnCategorie);
            this.Controls.Add(this.btnFournisseur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRM_Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.pnlAfficher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button btnArticle;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnFournisseur;
        private System.Windows.Forms.Button btnCategorie;
        private System.Windows.Forms.Button btnCdeClt;
        private System.Windows.Forms.Button btnCdeFrn;
        private System.Windows.Forms.Button btnEmploye;
        private System.Windows.Forms.Button btnEmpltStock;
        private System.Windows.Forms.Button btnFacture;
        private System.Windows.Forms.Panel pnlAfficher;
        private System.Windows.Forms.DataGridView dvgArticle;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}