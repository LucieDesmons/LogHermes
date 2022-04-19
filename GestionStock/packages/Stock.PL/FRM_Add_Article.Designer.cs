namespace Stock.Stock.PL
{
    partial class FRM_Add_Article
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
            this.FRM_Article = new System.Windows.Forms.Label();
            this.textNomVin = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textCep = new System.Windows.Forms.TextBox();
            this.textPrix = new System.Windows.Forms.TextBox();
            this.textAn = new System.Windows.Forms.TextBox();
            this.textNote = new System.Windows.Forms.TextBox();
            this.textQte = new System.Windows.Forms.TextBox();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelArticle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textCat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FRM_Article
            // 
            this.FRM_Article.AutoSize = true;
            this.FRM_Article.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRM_Article.ForeColor = System.Drawing.SystemColors.Control;
            this.FRM_Article.Location = new System.Drawing.Point(187, 6);
            this.FRM_Article.Name = "FRM_Article";
            this.FRM_Article.Size = new System.Drawing.Size(135, 28);
            this.FRM_Article.TabIndex = 0;
            this.FRM_Article.Text = "Ajout Article";
            // 
            // textNomVin
            // 
            this.textNomVin.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomVin.Location = new System.Drawing.Point(139, 74);
            this.textNomVin.Multiline = true;
            this.textNomVin.Name = "textNomVin";
            this.textNomVin.Size = new System.Drawing.Size(339, 36);
            this.textNomVin.TabIndex = 1;
            this.textNomVin.Text = "Millésime";
            // 
            // textDescription
            // 
            this.textDescription.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.Location = new System.Drawing.Point(139, 133);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(339, 77);
            this.textDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Année";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(283, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Note";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(13, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cépage*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(350, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Quantité disponible";
            // 
            // textCep
            // 
            this.textCep.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCep.Location = new System.Drawing.Point(139, 236);
            this.textCep.Multiline = true;
            this.textCep.Name = "textCep";
            this.textCep.Size = new System.Drawing.Size(114, 34);
            this.textCep.TabIndex = 10;
            this.textCep.Text = "Cépage";
            // 
            // textPrix
            // 
            this.textPrix.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrix.Location = new System.Drawing.Point(27, 334);
            this.textPrix.Multiline = true;
            this.textPrix.Name = "textPrix";
            this.textPrix.Size = new System.Drawing.Size(75, 22);
            this.textPrix.TabIndex = 11;
            // 
            // textAn
            // 
            this.textAn.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAn.Location = new System.Drawing.Point(139, 334);
            this.textAn.Multiline = true;
            this.textAn.Name = "textAn";
            this.textAn.Size = new System.Drawing.Size(89, 22);
            this.textAn.TabIndex = 12;
            // 
            // textNote
            // 
            this.textNote.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNote.Location = new System.Drawing.Point(265, 334);
            this.textNote.Multiline = true;
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(79, 22);
            this.textNote.TabIndex = 13;
            // 
            // textQte
            // 
            this.textQte.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQte.Location = new System.Drawing.Point(377, 334);
            this.textQte.Multiline = true;
            this.textQte.Name = "textQte";
            this.textQte.Size = new System.Drawing.Size(75, 22);
            this.textQte.TabIndex = 14;
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddArticle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddArticle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArticle.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArticle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAddArticle.Location = new System.Drawing.Point(124, 393);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(129, 37);
            this.btnAddArticle.TabIndex = 15;
            this.btnAddArticle.Text = "Ajouter";
            this.btnAddArticle.UseVisualStyleBackColor = false;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.FRM_Article);
            this.panel1.Location = new System.Drawing.Point(0, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 41);
            this.panel1.TabIndex = 17;
            // 
            // btnCancelArticle
            // 
            this.btnCancelArticle.FlatAppearance.BorderSize = 0;
            this.btnCancelArticle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCancelArticle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelArticle.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelArticle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCancelArticle.Location = new System.Drawing.Point(303, 393);
            this.btnCancelArticle.Name = "btnCancelArticle";
            this.btnCancelArticle.Size = new System.Drawing.Size(129, 37);
            this.btnCancelArticle.TabIndex = 18;
            this.btnCancelArticle.Text = "Annuler";
            this.btnCancelArticle.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 5);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(0, 372);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(523, 5);
            this.panel3.TabIndex = 20;
            // 
            // textCat
            // 
            this.textCat.Location = new System.Drawing.Point(439, 248);
            this.textCat.Name = "textCat";
            this.textCat.Size = new System.Drawing.Size(39, 22);
            this.textCat.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(311, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Catégorie";
            // 
            // FRM_Add_Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(508, 458);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textCat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCancelArticle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddArticle);
            this.Controls.Add(this.textQte);
            this.Controls.Add(this.textNote);
            this.Controls.Add(this.textAn);
            this.Controls.Add(this.textPrix);
            this.Controls.Add(this.textCep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textNomVin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Add_Article";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Add_Article";
            this.Load += new System.EventHandler(this.FRM_Add_Article_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FRM_Article;
        private System.Windows.Forms.TextBox textNomVin;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCep;
        private System.Windows.Forms.TextBox textPrix;
        private System.Windows.Forms.TextBox textAn;
        private System.Windows.Forms.TextBox textNote;
        private System.Windows.Forms.TextBox textQte;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelArticle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textCat;
        private System.Windows.Forms.Label label8;
    }
}