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
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMotdePasse = new System.Windows.Forms.Label();
            this.lblMessageErreur = new System.Windows.Forms.Label();
            this.chkAffiche = new System.Windows.Forms.CheckBox();
            this.textIdentifiant = new System.Windows.Forms.TextBox();
            this.textMotPasse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(538, 4);
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
            this.panel3.Size = new System.Drawing.Size(538, 4);
            this.panel3.TabIndex = 3;
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitre.AutoSize = true;
            this.lblTitre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitre.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTitre.Location = new System.Drawing.Point(156, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(244, 28);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "Identification Utilisateur";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitre.Click += new System.EventHandler(this.lblTitre_Click);
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(101, 92);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(107, 24);
            this.lblIdentifiant.TabIndex = 5;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // lblMotdePasse
            // 
            this.lblMotdePasse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMotdePasse.AutoSize = true;
            this.lblMotdePasse.Location = new System.Drawing.Point(99, 151);
            this.lblMotdePasse.Name = "lblMotdePasse";
            this.lblMotdePasse.Size = new System.Drawing.Size(130, 24);
            this.lblMotdePasse.TabIndex = 6;
            this.lblMotdePasse.Text = "Mot de passe :";
            // 
            // lblMessageErreur
            // 
            this.lblMessageErreur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessageErreur.AutoSize = true;
            this.lblMessageErreur.Location = new System.Drawing.Point(176, 222);
            this.lblMessageErreur.Name = "lblMessageErreur";
            this.lblMessageErreur.Size = new System.Drawing.Size(169, 24);
            this.lblMessageErreur.TabIndex = 7;
            this.lblMessageErreur.Text = "Erreur identifiants !";
            this.lblMessageErreur.Visible = false;
            // 
            // chkAffiche
            // 
            this.chkAffiche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAffiche.AutoSize = true;
            this.chkAffiche.Location = new System.Drawing.Point(241, 184);
            this.chkAffiche.Name = "chkAffiche";
            this.chkAffiche.Size = new System.Drawing.Size(211, 28);
            this.chkAffiche.TabIndex = 8;
            this.chkAffiche.Text = "Afficher mot de passe";
            this.chkAffiche.UseVisualStyleBackColor = true;
            this.chkAffiche.CheckedChanged += new System.EventHandler(this.chkAffiche_CheckedChanged);
            // 
            // textIdentifiant
            // 
            this.textIdentifiant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textIdentifiant.Location = new System.Drawing.Point(241, 89);
            this.textIdentifiant.Name = "textIdentifiant";
            this.textIdentifiant.Size = new System.Drawing.Size(214, 32);
            this.textIdentifiant.TabIndex = 9;
            this.textIdentifiant.Text = "Nom Utilisateur";
            // 
            // textMotPasse
            // 
            this.textMotPasse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMotPasse.Location = new System.Drawing.Point(241, 149);
            this.textMotPasse.Name = "textMotPasse";
            this.textMotPasse.Size = new System.Drawing.Size(214, 32);
            this.textMotPasse.TabIndex = 10;
            this.textMotPasse.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = " négosud";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Image = global::GestionStock.Properties.Resources.close_32;
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitter.Location = new System.Drawing.Point(358, 269);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(118, 36);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click_1);
            // 
            // btnValider
            // 
            this.btnValider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnValider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnValider.Image = global::GestionStock.Properties.Resources.checkmark32;
            this.btnValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValider.Location = new System.Drawing.Point(166, 269);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(127, 36);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // FRM_Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(538, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMotPasse);
            this.Controls.Add(this.textIdentifiant);
            this.Controls.Add(this.chkAffiche);
            this.Controls.Add(this.lblMessageErreur);
            this.Controls.Add(this.lblMotdePasse);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
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

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblMotdePasse;
        private System.Windows.Forms.Label lblMessageErreur;
        private System.Windows.Forms.CheckBox chkAffiche;
        private System.Windows.Forms.TextBox textIdentifiant;
        private System.Windows.Forms.TextBox textMotPasse;
        public System.Windows.Forms.Label label1;
    }
}