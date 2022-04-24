namespace GestionStock.Stock.PL
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.pnlAfficher = new System.Windows.Forms.Panel();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnCmde = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::GestionStock.Properties.Resources.close_32;
            this.btnExit.Location = new System.Drawing.Point(1496, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 51);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(69, 146);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(116, 38);
            this.btnClient.TabIndex = 1;
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // pnlAfficher
            // 
            this.pnlAfficher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAfficher.Location = new System.Drawing.Point(206, 114);
            this.pnlAfficher.Name = "pnlAfficher";
            this.pnlAfficher.Size = new System.Drawing.Size(1374, 701);
            this.pnlAfficher.TabIndex = 2;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(69, 278);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(116, 38);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Article";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(69, 413);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(116, 38);
            this.btnCat.TabIndex = 4;
            this.btnCat.Text = "Catégorie";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnCmde
            // 
            this.btnCmde.Location = new System.Drawing.Point(69, 546);
            this.btnCmde.Name = "btnCmde";
            this.btnCmde.Size = new System.Drawing.Size(116, 38);
            this.btnCmde.TabIndex = 5;
            this.btnCmde.Text = "Commande";
            this.btnCmde.UseVisualStyleBackColor = true;
            this.btnCmde.Click += new System.EventHandler(this.btnCmde_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lblTitre);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1568, 112);
            this.panel1.TabIndex = 6;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitre.Location = new System.Drawing.Point(665, 31);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(148, 37);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "NEGOSUD";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Article";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Catégorie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 602);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Commande";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Location = new System.Drawing.Point(12, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1960, 10);
            this.panel2.TabIndex = 2;
            // 
            // FRM_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCmde);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.pnlAfficher);
            this.Controls.Add(this.btnClient);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRM_Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Accueil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Panel pnlAfficher;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnCmde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
    }
}