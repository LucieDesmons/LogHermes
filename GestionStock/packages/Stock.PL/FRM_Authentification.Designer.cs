namespace Stock.Stock.PL
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblIdent = new System.Windows.Forms.Label();
            this.lblMotdePasse = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMotPasse = new System.Windows.Forms.TextBox();
            this.chkBoxAffiche = new System.Windows.Forms.CheckBox();
            this.lblMessageErreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 4);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 4);
            this.panel2.TabIndex = 1;
            this.panel2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identification";
            this.label1.UseWaitCursor = true;
            // 
            // btnValider
            // 
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnValider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.Firebrick;
            this.btnValider.Image = global::Stock.Properties.Resources.lock_open_32;
            this.btnValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValider.Location = new System.Drawing.Point(81, 266);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(116, 38);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblIdent
            // 
            this.lblIdent.AutoSize = true;
            this.lblIdent.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdent.ForeColor = System.Drawing.Color.Firebrick;
            this.lblIdent.Location = new System.Drawing.Point(79, 92);
            this.lblIdent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdent.Name = "lblIdent";
            this.lblIdent.Size = new System.Drawing.Size(87, 19);
            this.lblIdent.TabIndex = 6;
            this.lblIdent.Text = "Identifiant :";
            this.lblIdent.UseWaitCursor = true;
            // 
            // lblMotdePasse
            // 
            this.lblMotdePasse.AutoSize = true;
            this.lblMotdePasse.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotdePasse.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMotdePasse.Location = new System.Drawing.Point(79, 144);
            this.lblMotdePasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotdePasse.Name = "lblMotdePasse";
            this.lblMotdePasse.Size = new System.Drawing.Size(107, 19);
            this.lblMotdePasse.TabIndex = 7;
            this.lblMotdePasse.Text = "Mot de passe :";
            this.lblMotdePasse.UseWaitCursor = true;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Firebrick;
            this.btnExit.Image = global::Stock.Properties.Resources.lock_32;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(256, 266);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 38);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Quitter";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentifiant.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentifiant.ForeColor = System.Drawing.Color.Firebrick;
            this.txtIdentifiant.Location = new System.Drawing.Point(210, 89);
            this.txtIdentifiant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdentifiant.MaxLength = 30;
            this.txtIdentifiant.Multiline = true;
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(162, 24);
            this.txtIdentifiant.TabIndex = 9;
            this.txtIdentifiant.Text = "Nom Utilisateur";
            // 
            // txtMotPasse
            // 
            this.txtMotPasse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotPasse.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotPasse.ForeColor = System.Drawing.Color.Firebrick;
            this.txtMotPasse.Location = new System.Drawing.Point(210, 141);
            this.txtMotPasse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMotPasse.MaxLength = 20;
            this.txtMotPasse.Name = "txtMotPasse";
            this.txtMotPasse.Size = new System.Drawing.Size(162, 27);
            this.txtMotPasse.TabIndex = 10;
            this.txtMotPasse.UseSystemPasswordChar = true;
            // 
            // chkBoxAffiche
            // 
            this.chkBoxAffiche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBoxAffiche.AutoSize = true;
            this.chkBoxAffiche.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkBoxAffiche.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxAffiche.ForeColor = System.Drawing.Color.Firebrick;
            this.chkBoxAffiche.Location = new System.Drawing.Point(210, 187);
            this.chkBoxAffiche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBoxAffiche.Name = "chkBoxAffiche";
            this.chkBoxAffiche.Size = new System.Drawing.Size(168, 21);
            this.chkBoxAffiche.TabIndex = 11;
            this.chkBoxAffiche.Text = "Afficher le mot de passe";
            this.chkBoxAffiche.UseVisualStyleBackColor = true;
            this.chkBoxAffiche.CheckedChanged += new System.EventHandler(this.chkBoxAffiche_CheckedChanged);
            // 
            // lblMessageErreur
            // 
            this.lblMessageErreur.AutoSize = true;
            this.lblMessageErreur.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageErreur.ForeColor = System.Drawing.Color.Black;
            this.lblMessageErreur.Location = new System.Drawing.Point(129, 225);
            this.lblMessageErreur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessageErreur.Name = "lblMessageErreur";
            this.lblMessageErreur.Size = new System.Drawing.Size(204, 23);
            this.lblMessageErreur.TabIndex = 12;
            this.lblMessageErreur.Text = "Mot de passe invalide !!!";
            this.lblMessageErreur.UseWaitCursor = true;
            this.lblMessageErreur.Visible = false;
            // 
            // FRM_Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(446, 350);
            this.Controls.Add(this.lblMessageErreur);
            this.Controls.Add(this.chkBoxAffiche);
            this.Controls.Add(this.txtMotPasse);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMotdePasse);
            this.Controls.Add(this.lblIdent);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRM_Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblIdent;
        private System.Windows.Forms.Label lblMotdePasse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMotPasse;
        private System.Windows.Forms.CheckBox chkBoxAffiche;
        private System.Windows.Forms.Label lblMessageErreur;
    }
}