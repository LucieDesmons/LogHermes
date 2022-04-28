namespace GestionStock.Stock.PL
{
    partial class FRM_AjoutCat
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuitArt = new System.Windows.Forms.Button();
            this.btnValidCat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFicheCat = new System.Windows.Forms.Label();
            this.textCat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Location = new System.Drawing.Point(25, 208);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 10);
            this.panel2.TabIndex = 87;
            // 
            // btnQuitArt
            // 
            this.btnQuitArt.BackColor = System.Drawing.Color.MistyRose;
            this.btnQuitArt.FlatAppearance.BorderSize = 0;
            this.btnQuitArt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnQuitArt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnQuitArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitArt.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitArt.ForeColor = System.Drawing.Color.Firebrick;
            this.btnQuitArt.Image = global::GestionStock.Properties.Resources.close_32;
            this.btnQuitArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitArt.Location = new System.Drawing.Point(551, 247);
            this.btnQuitArt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitArt.Name = "btnQuitArt";
            this.btnQuitArt.Size = new System.Drawing.Size(123, 43);
            this.btnQuitArt.TabIndex = 86;
            this.btnQuitArt.Text = "Quitter";
            this.btnQuitArt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitArt.UseVisualStyleBackColor = false;
            this.btnQuitArt.Click += new System.EventHandler(this.btnQuitArt_Click);
            // 
            // btnValidCat
            // 
            this.btnValidCat.BackColor = System.Drawing.Color.MistyRose;
            this.btnValidCat.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnValidCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnValidCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnValidCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidCat.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidCat.ForeColor = System.Drawing.Color.Firebrick;
            this.btnValidCat.Image = global::GestionStock.Properties.Resources.checkmark32;
            this.btnValidCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidCat.Location = new System.Drawing.Point(197, 247);
            this.btnValidCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValidCat.Name = "btnValidCat";
            this.btnValidCat.Size = new System.Drawing.Size(123, 43);
            this.btnValidCat.TabIndex = 85;
            this.btnValidCat.Text = "Valider";
            this.btnValidCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidCat.UseVisualStyleBackColor = false;
            this.btnValidCat.Click += new System.EventHandler(this.btnValidCat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.lblFicheCat);
            this.panel1.Location = new System.Drawing.Point(31, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 66);
            this.panel1.TabIndex = 84;
            // 
            // lblFicheCat
            // 
            this.lblFicheCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFicheCat.AutoSize = true;
            this.lblFicheCat.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFicheCat.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblFicheCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFicheCat.Location = new System.Drawing.Point(309, 17);
            this.lblFicheCat.Name = "lblFicheCat";
            this.lblFicheCat.Size = new System.Drawing.Size(193, 30);
            this.lblFicheCat.TabIndex = 0;
            this.lblFicheCat.Text = "Fiche Catégorie";
            // 
            // textCat
            // 
            this.textCat.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCat.ForeColor = System.Drawing.Color.Black;
            this.textCat.Location = new System.Drawing.Point(197, 130);
            this.textCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCat.Name = "textCat";
            this.textCat.Size = new System.Drawing.Size(475, 28);
            this.textCat.TabIndex = 83;
            this.textCat.Text = "Nouvelle catégorie";
            this.textCat.Enter += new System.EventHandler(this.textCat_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(439, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(76, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 81;
            this.label1.Text = "Dénomination";
            // 
            // FRM_AjoutCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 320);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnQuitArt);
            this.Controls.Add(this.btnValidCat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_AjoutCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AjoutCat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnQuitArt;
        public System.Windows.Forms.Button btnValidCat;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblFicheCat;
        public System.Windows.Forms.TextBox textCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}