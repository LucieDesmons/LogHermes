namespace GestionStock.Stock.PL
{
    partial class FRM_Produit_Commande
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQte = new System.Windows.Forms.Label();
            this.lblRemise = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textQte = new System.Windows.Forms.TextBox();
            this.textRemise = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblPour = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(180, 111);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(26, 24);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "ln";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(180, 167);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(23, 24);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "ls";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(177, 226);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(26, 24);
            this.lblPrix.TabIndex = 2;
            this.lblPrix.Text = "lp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom Produit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stock :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix Produit :";
            // 
            // lblQte
            // 
            this.lblQte.AutoSize = true;
            this.lblQte.Location = new System.Drawing.Point(307, 52);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(93, 24);
            this.lblQte.TabIndex = 6;
            this.lblQte.Text = "Quantité :";
            // 
            // lblRemise
            // 
            this.lblRemise.AutoSize = true;
            this.lblRemise.Location = new System.Drawing.Point(307, 108);
            this.lblRemise.Name = "lblRemise";
            this.lblRemise.Size = new System.Drawing.Size(79, 24);
            this.lblRemise.TabIndex = 7;
            this.lblRemise.Text = "Remise :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total :";
            // 
            // textQte
            // 
            this.textQte.Location = new System.Drawing.Point(443, 49);
            this.textQte.Name = "textQte";
            this.textQte.Size = new System.Drawing.Size(148, 32);
            this.textQte.TabIndex = 9;
            this.textQte.TextChanged += new System.EventHandler(this.textQte_TextChanged);
            this.textQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textQte_KeyPress);
            // 
            // textRemise
            // 
            this.textRemise.Location = new System.Drawing.Point(443, 105);
            this.textRemise.Name = "textRemise";
            this.textRemise.Size = new System.Drawing.Size(117, 32);
            this.textRemise.TabIndex = 10;
            this.textRemise.TextChanged += new System.EventHandler(this.textRemise_TextChanged);
            this.textRemise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textRemise_KeyPress);
            // 
            // textTotal
            // 
            this.textTotal.Enabled = false;
            this.textTotal.Location = new System.Drawing.Point(443, 164);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(148, 32);
            this.textTotal.TabIndex = 11;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(281, 267);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(159, 44);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblPour
            // 
            this.lblPour.AutoSize = true;
            this.lblPour.Location = new System.Drawing.Point(571, 108);
            this.lblPour.Name = "lblPour";
            this.lblPour.Size = new System.Drawing.Size(20, 24);
            this.lblPour.TabIndex = 13;
            this.lblPour.Text = "%";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(44, 52);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(128, 30);
            this.label.TabIndex = 15;
            this.label.Text = "Id Produit :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(180, 52);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 30);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "id";
            // 
            // FRM_Produit_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 340);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblPour);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textRemise);
            this.Controls.Add(this.textQte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRemise);
            this.Controls.Add(this.lblQte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblNom);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Produit_Commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.Label lblRemise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textQte;
        private System.Windows.Forms.TextBox textRemise;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblPour;
        public System.Windows.Forms.Label lblNom;
        public System.Windows.Forms.Label lblStock;
        public System.Windows.Forms.Label lblPrix;
        public System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.Label lblId;
    }
}