namespace GestionStock.Stock.PL
{
    partial class FRM_Authentification
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textMotPasse = new System.Windows.Forms.TextBox();
            this.textIdentifiant = new System.Windows.Forms.TextBox();
            this.chkAffiche = new System.Windows.Forms.CheckBox();
            this.lblMessageErreur = new System.Windows.Forms.Label();
            this.lblMotdePasse = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 0);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 6);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 0);
            this.panel3.TabIndex = 3;
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitre.AutoSize = true;
            this.lblTitre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitre.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitre.Location = new System.Drawing.Point(154, 22);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(252, 28);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "Identification Utilisateur";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = " négosud";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textMotPasse
            // 
            this.textMotPasse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMotPasse.Location = new System.Drawing.Point(232, 126);
            this.textMotPasse.Name = "textMotPasse";
            this.textMotPasse.Size = new System.Drawing.Size(214, 32);
            this.textMotPasse.TabIndex = 26;
            this.textMotPasse.UseSystemPasswordChar = true;
            // 
            // textIdentifiant
            // 
            this.textIdentifiant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textIdentifiant.Location = new System.Drawing.Point(231, 75);
            this.textIdentifiant.Name = "textIdentifiant";
            this.textIdentifiant.Size = new System.Drawing.Size(214, 32);
            this.textIdentifiant.TabIndex = 25;
            this.textIdentifiant.Text = "Nom Utilisateur";
            // 
            // chkAffiche
            // 
            this.chkAffiche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAffiche.AutoSize = true;
            this.chkAffiche.BackColor = System.Drawing.Color.Transparent;
            this.chkAffiche.ForeColor = System.Drawing.Color.Firebrick;
            this.chkAffiche.Location = new System.Drawing.Point(155, 170);
            this.chkAffiche.Name = "chkAffiche";
            this.chkAffiche.Size = new System.Drawing.Size(211, 28);
            this.chkAffiche.TabIndex = 24;
            this.chkAffiche.Text = "Afficher mot de passe";
            this.chkAffiche.UseVisualStyleBackColor = false;
            this.chkAffiche.CheckedChanged += new System.EventHandler(this.chkAffiche_CheckedChanged_1);
            // 
            // lblMessageErreur
            // 
            this.lblMessageErreur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessageErreur.AutoSize = true;
            this.lblMessageErreur.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageErreur.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMessageErreur.Location = new System.Drawing.Point(169, 208);
            this.lblMessageErreur.Name = "lblMessageErreur";
            this.lblMessageErreur.Size = new System.Drawing.Size(169, 24);
            this.lblMessageErreur.TabIndex = 23;
            this.lblMessageErreur.Text = "Erreur identifiants !";
            this.lblMessageErreur.Visible = false;
            // 
            // lblMotdePasse
            // 
            this.lblMotdePasse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMotdePasse.AutoSize = true;
            this.lblMotdePasse.BackColor = System.Drawing.Color.Transparent;
            this.lblMotdePasse.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMotdePasse.Location = new System.Drawing.Point(92, 128);
            this.lblMotdePasse.Name = "lblMotdePasse";
            this.lblMotdePasse.Size = new System.Drawing.Size(130, 24);
            this.lblMotdePasse.TabIndex = 22;
            this.lblMotdePasse.Text = "Mot de passe :";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentifiant.ForeColor = System.Drawing.Color.Firebrick;
            this.lblIdentifiant.Location = new System.Drawing.Point(94, 78);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(107, 24);
            this.lblIdentifiant.TabIndex = 21;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitter.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.ForeColor = System.Drawing.Color.Firebrick;
            this.btnQuitter.Image = global::GestionStock.Properties.Resources.close_32;
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitter.Location = new System.Drawing.Point(292, 255);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(118, 36);
            this.btnQuitter.TabIndex = 20;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click_1);
            // 
            // btnValider
            // 
            this.btnValider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValider.BackColor = System.Drawing.Color.Transparent;
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnValider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnValider.Image = global::GestionStock.Properties.Resources.checkmark32;
            this.btnValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValider.Location = new System.Drawing.Point(145, 255);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(127, 36);
            this.btnValider.TabIndex = 19;
            this.btnValider.Text = "Valider";
            this.btnValider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click_1);
            // 
            // FRM_Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(538, 367);
            this.Controls.Add(this.textMotPasse);
            this.Controls.Add(this.textIdentifiant);
            this.Controls.Add(this.chkAffiche);
            this.Controls.Add(this.lblMessageErreur);
            this.Controls.Add(this.lblMotdePasse);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Firebrick;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Authentification";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitre;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMotPasse;
        private System.Windows.Forms.TextBox textIdentifiant;
        private System.Windows.Forms.CheckBox chkAffiche;
        private System.Windows.Forms.Label lblMessageErreur;
        private System.Windows.Forms.Label lblMotdePasse;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnValider;
    }
}