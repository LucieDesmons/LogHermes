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
            this.gbArticle = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.gbArticle.SuspendLayout();
            this.gbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(158, 87);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(26, 24);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "ln";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(158, 143);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(23, 24);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "ls";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(155, 202);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(26, 24);
            this.lblPrix.TabIndex = 2;
            this.lblPrix.Text = "lp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom Produit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stock :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix Produit :";
            // 
            // lblQte
            // 
            this.lblQte.AutoSize = true;
            this.lblQte.Location = new System.Drawing.Point(269, 66);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(93, 24);
            this.lblQte.TabIndex = 6;
            this.lblQte.Text = "Quantité :";
            // 
            // lblRemise
            // 
            this.lblRemise.AutoSize = true;
            this.lblRemise.Location = new System.Drawing.Point(269, 122);
            this.lblRemise.Name = "lblRemise";
            this.lblRemise.Size = new System.Drawing.Size(79, 24);
            this.lblRemise.TabIndex = 7;
            this.lblRemise.Text = "Remise :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total :";
            // 
            // textQte
            // 
            this.textQte.Location = new System.Drawing.Point(405, 63);
            this.textQte.Name = "textQte";
            this.textQte.Size = new System.Drawing.Size(148, 32);
            this.textQte.TabIndex = 9;
            this.textQte.TextChanged += new System.EventHandler(this.textQte_TextChanged);
            this.textQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textQte_KeyPress);
            // 
            // textRemise
            // 
            this.textRemise.Location = new System.Drawing.Point(405, 119);
            this.textRemise.Name = "textRemise";
            this.textRemise.Size = new System.Drawing.Size(117, 32);
            this.textRemise.TabIndex = 10;
            this.textRemise.TextChanged += new System.EventHandler(this.textRemise_TextChanged);
            this.textRemise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textRemise_KeyPress);
            // 
            // textTotal
            // 
            this.textTotal.Enabled = false;
            this.textTotal.Location = new System.Drawing.Point(405, 178);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(148, 32);
            this.textTotal.TabIndex = 11;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(453, 22);
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
            this.lblPour.Location = new System.Drawing.Point(533, 122);
            this.lblPour.Name = "lblPour";
            this.lblPour.Size = new System.Drawing.Size(20, 24);
            this.lblPour.TabIndex = 13;
            this.lblPour.Text = "%";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(102, 24);
            this.label.TabIndex = 15;
            this.label.Text = "Id Produit :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(158, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 24);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "id";
            // 
            // gbArticle
            // 
            this.gbArticle.Controls.Add(this.gbDetail);
            this.gbArticle.Controls.Add(this.lblPour);
            this.gbArticle.Controls.Add(this.groupBox2);
            this.gbArticle.Controls.Add(this.lblQte);
            this.gbArticle.Controls.Add(this.textTotal);
            this.gbArticle.Controls.Add(this.lblRemise);
            this.gbArticle.Controls.Add(this.textRemise);
            this.gbArticle.Controls.Add(this.label4);
            this.gbArticle.Controls.Add(this.textQte);
            this.gbArticle.Location = new System.Drawing.Point(48, 81);
            this.gbArticle.Name = "gbArticle";
            this.gbArticle.Size = new System.Drawing.Size(579, 289);
            this.gbArticle.TabIndex = 16;
            this.gbArticle.TabStop = false;
            this.gbArticle.Text = "Article(s) vendu(s)";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(62, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(32, 10);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.label);
            this.gbDetail.Controls.Add(this.lblNom);
            this.gbDetail.Controls.Add(this.lblId);
            this.gbDetail.Controls.Add(this.lblStock);
            this.gbDetail.Controls.Add(this.lblPrix);
            this.gbDetail.Controls.Add(this.label1);
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Controls.Add(this.label3);
            this.gbDetail.Location = new System.Drawing.Point(15, 38);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(248, 237);
            this.gbDetail.TabIndex = 1;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Détails";
            // 
            // FRM_Produit_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 417);
            this.Controls.Add(this.gbArticle);
            this.Controls.Add(this.btnValider);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Produit_Commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produit";
            this.gbArticle.ResumeLayout(false);
            this.gbArticle.PerformLayout();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.Label lblRemise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblPour;
        public System.Windows.Forms.Label lblNom;
        public System.Windows.Forms.Label lblStock;
        public System.Windows.Forms.Label lblPrix;
        public System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.GroupBox gbArticle;
        public System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox textQte;
        public System.Windows.Forms.TextBox textRemise;
    }
}