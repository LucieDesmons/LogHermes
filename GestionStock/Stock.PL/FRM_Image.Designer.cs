namespace GestionStock.Stock.PL
{
    partial class FRM_Image
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
            this.button1 = new System.Windows.Forms.Button();
            this.picImageProduit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NomProduit = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::GestionStock.Properties.Resources.close_32;
            this.button1.Location = new System.Drawing.Point(855, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 39);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picImageProduit
            // 
            this.picImageProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImageProduit.Location = new System.Drawing.Point(71, 93);
            this.picImageProduit.Name = "picImageProduit";
            this.picImageProduit.Size = new System.Drawing.Size(755, 666);
            this.picImageProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageProduit.TabIndex = 0;
            this.picImageProduit.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.NomProduit);
            this.panel1.Controls.Add(this.lblImage);
            this.panel1.Location = new System.Drawing.Point(46, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 66);
            this.panel1.TabIndex = 65;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // NomProduit
            // 
            this.NomProduit.AutoSize = true;
            this.NomProduit.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomProduit.ForeColor = System.Drawing.SystemColors.Control;
            this.NomProduit.Location = new System.Drawing.Point(313, 29);
            this.NomProduit.Name = "NomProduit";
            this.NomProduit.Size = new System.Drawing.Size(0, 24);
            this.NomProduit.TabIndex = 1;
            // 
            // lblImage
            // 
            this.lblImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(317, 5);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(121, 24);
            this.lblImage.TabIndex = 0;
            this.lblImage.Text = "Image Article";
            // 
            // FRM_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 794);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picImageProduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Image";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Image";
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox picImageProduit;
        public System.Windows.Forms.Label NomProduit;
        public System.Windows.Forms.Label lblImage;
    }
}