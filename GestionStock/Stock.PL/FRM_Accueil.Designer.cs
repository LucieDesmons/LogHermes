﻿namespace GestionStock.Stock.PL
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
            this.pnlAfficher = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCmde = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAfficher
            // 
            this.pnlAfficher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAfficher.BackColor = System.Drawing.Color.Transparent;
            this.pnlAfficher.Location = new System.Drawing.Point(181, 109);
            this.pnlAfficher.Name = "pnlAfficher";
            this.pnlAfficher.Size = new System.Drawing.Size(898, 740);
            this.pnlAfficher.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTitre);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 112);
            this.panel1.TabIndex = 6;
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitre.Location = new System.Drawing.Point(3, 24);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(159, 42);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "négosud";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::GestionStock.Properties.Resources.close_32;
            this.btnExit.Location = new System.Drawing.Point(985, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 51);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Location = new System.Drawing.Point(13, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 8);
            this.panel2.TabIndex = 2;
            // 
            // btnCmde
            // 
            this.btnCmde.BackColor = System.Drawing.Color.Transparent;
            this.btnCmde.FlatAppearance.BorderSize = 0;
            this.btnCmde.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCmde.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCmde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCmde.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmde.Image = global::GestionStock.Properties.Resources.receipt48;
            this.btnCmde.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCmde.Location = new System.Drawing.Point(20, 546);
            this.btnCmde.Name = "btnCmde";
            this.btnCmde.Size = new System.Drawing.Size(116, 93);
            this.btnCmde.TabIndex = 5;
            this.btnCmde.Text = "Commande";
            this.btnCmde.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCmde.UseVisualStyleBackColor = false;
            this.btnCmde.Click += new System.EventHandler(this.btnCmde_Click);
            // 
            // btnCat
            // 
            this.btnCat.BackColor = System.Drawing.Color.Transparent;
            this.btnCat.FlatAppearance.BorderSize = 0;
            this.btnCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCat.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat.ForeColor = System.Drawing.Color.Transparent;
            this.btnCat.Image = global::GestionStock.Properties.Resources.cat48;
            this.btnCat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCat.Location = new System.Drawing.Point(20, 403);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(116, 93);
            this.btnCat.TabIndex = 4;
            this.btnCat.Text = "Catégorie";
            this.btnCat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCat.UseVisualStyleBackColor = false;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Image = global::GestionStock.Properties.Resources.wine48;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProduct.Location = new System.Drawing.Point(20, 278);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(116, 93);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Article";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Transparent;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.Transparent;
            this.btnClient.Image = global::GestionStock.Properties.Resources.Client48;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClient.Location = new System.Drawing.Point(20, 141);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(116, 93);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client";
            this.btnClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // FRM_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GestionStock.Properties.Resources.vigne2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 848);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlAfficher);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCmde);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.btnProduct);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRM_Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Accueil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlAfficher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnClient;
        public System.Windows.Forms.Button btnProduct;
        public System.Windows.Forms.Button btnCat;
        public System.Windows.Forms.Button btnCmde;
    }
}