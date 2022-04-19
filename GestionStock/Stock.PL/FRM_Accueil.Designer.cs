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
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::GestionStock.Properties.Resources.close_32;
            this.btnExit.Location = new System.Drawing.Point(1559, 23);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 39);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(69, 114);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(116, 38);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client";
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
            this.pnlAfficher.Size = new System.Drawing.Size(1399, 701);
            this.pnlAfficher.TabIndex = 2;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(69, 175);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(116, 38);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Article";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(69, 244);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(116, 38);
            this.btnCat.TabIndex = 4;
            this.btnCat.Text = "Catégorie";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnCmde
            // 
            this.btnCmde.Location = new System.Drawing.Point(69, 313);
            this.btnCmde.Name = "btnCmde";
            this.btnCmde.Size = new System.Drawing.Size(116, 38);
            this.btnCmde.TabIndex = 5;
            this.btnCmde.Text = "Commande";
            this.btnCmde.UseVisualStyleBackColor = true;
            this.btnCmde.Click += new System.EventHandler(this.btnCmde_Click);
            // 
            // FRM_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 865);
            this.Controls.Add(this.btnCmde);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.pnlAfficher);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRM_Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Panel pnlAfficher;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnCmde;
    }
}