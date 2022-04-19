namespace Stock.Stock.PL
{
    partial class USR_Article
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSuppArticle = new System.Windows.Forms.Button();
            this.btnModifArticle = new System.Windows.Forms.Button();
            this.btnNewArticle = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSuppArticle
            // 
            this.btnSuppArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSuppArticle.FlatAppearance.BorderSize = 0;
            this.btnSuppArticle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSuppArticle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuppArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppArticle.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppArticle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSuppArticle.Image = global::Stock.Properties.Resources.Recycle1;
            this.btnSuppArticle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppArticle.Location = new System.Drawing.Point(329, 10);
            this.btnSuppArticle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuppArticle.Name = "btnSuppArticle";
            this.btnSuppArticle.Size = new System.Drawing.Size(156, 46);
            this.btnSuppArticle.TabIndex = 2;
            this.btnSuppArticle.Text = "Supprimer";
            this.btnSuppArticle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuppArticle.UseVisualStyleBackColor = false;
            // 
            // btnModifArticle
            // 
            this.btnModifArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnModifArticle.FlatAppearance.BorderSize = 0;
            this.btnModifArticle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnModifArticle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModifArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifArticle.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifArticle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnModifArticle.Image = global::Stock.Properties.Resources.refresh1;
            this.btnModifArticle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifArticle.Location = new System.Drawing.Point(519, 10);
            this.btnModifArticle.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifArticle.Name = "btnModifArticle";
            this.btnModifArticle.Size = new System.Drawing.Size(156, 46);
            this.btnModifArticle.TabIndex = 1;
            this.btnModifArticle.Text = "Modifier";
            this.btnModifArticle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifArticle.UseVisualStyleBackColor = false;
            // 
            // btnNewArticle
            // 
            this.btnNewArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNewArticle.FlatAppearance.BorderSize = 0;
            this.btnNewArticle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNewArticle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNewArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewArticle.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewArticle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnNewArticle.Image = global::Stock.Properties.Resources.add1;
            this.btnNewArticle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewArticle.Location = new System.Drawing.Point(136, 10);
            this.btnNewArticle.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewArticle.Name = "btnNewArticle";
            this.btnNewArticle.Size = new System.Drawing.Size(156, 46);
            this.btnNewArticle.TabIndex = 0;
            this.btnNewArticle.Text = "Ajouter";
            this.btnNewArticle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewArticle.UseVisualStyleBackColor = false;
            this.btnNewArticle.Click += new System.EventHandler(this.btnNewArticle_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Firebrick;
            this.txtSearch.Location = new System.Drawing.Point(398, 75);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 27);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Recherche...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 19;
            this.comboBox1.Items.AddRange(new object[] {
            "Nom",
            "Note",
            "Cepage",
            "Prix",
            "Quantite"});
            this.comboBox1.Location = new System.Drawing.Point(136, 75);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 27);
            this.comboBox1.TabIndex = 4;
            // 
            // USR_Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSuppArticle);
            this.Controls.Add(this.btnModifArticle);
            this.Controls.Add(this.btnNewArticle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "USR_Article";
            this.Size = new System.Drawing.Size(939, 225);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewArticle;
        private System.Windows.Forms.Button btnModifArticle;
        private System.Windows.Forms.Button btnSuppArticle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
