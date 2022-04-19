﻿using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GestionStock.Stock.PL
{
    public partial class FRM_AjoutArt : Form
    {
        private dbStockContext db;
        private UserControl usarticle;
        public FRM_AjoutArt(UserControl userA)
        {
            InitializeComponent();
            
            db = new dbStockContext();
            usarticle = userA;
            comboCatArt.DataSource = db.CATEGORIE.ToList();// Appelle les donnée de la table Catégorie
            comboCatArt.DisplayMember = "Nom_Categorie";
            comboCatArt.ValueMember = "Id_Categorie";
        }
        string testobligatoire()
        {
            if (textDenomination.Text == "" || textDenomination.Text == "Dénomination")
            {
                return "Entrer dénomination article";
            }

            return null;
        }



        private void btnQuitArt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnnulerArt_Click(object sender, EventArgs e)
        {
            //Vider le formulaire
            textDenomination.Text = "Dénomination"; textDenomination.ForeColor = Color.Silver;
            textPrix.Text = "Prix"; textPrix.ForeColor = Color.Silver;
            textQteArt.Text = "Quantité"; textQteArt.ForeColor = Color.Silver;
            comboCatArt.Text = "";
            picArt.Image = null;

        }
        public int Id_Produit;
        private void btnValidArt_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lblFicheArt.Text == "Fiche Article")
                {
                    BL.CLS_Article cLS_Article = new BL.CLS_Article();
                    MemoryStream MR = new MemoryStream();
                    picArt.Image.Save(MR, picArt.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();
                    if (cLS_Article.Ajouter_Produit(textDenomination.Text, int.Parse(textQteArt.Text), textPrix.Text, byteimageP, Convert.ToInt32(comboCatArt.SelectedValue)) == true)
                    {
                        MessageBox.Show("Produit ajouté", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (usarticle as USR_Article).Actualiserdgv();
                    }
                    else
                    {
                        MessageBox.Show("Produit déjà créé", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else //modification
                {
                    MemoryStream MR = new MemoryStream();
                    picArt.Image.Save(MR, picArt.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();
                    BL.CLS_Article cLS_Article = new BL.CLS_Article();
                    DialogResult dr = MessageBox.Show("Voulez-vous modifier l'article ?", "modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        cLS_Article.Modify_Produit(Id_Produit, textDenomination.Text, int.Parse(textQteArt.Text), textPrix.Text, byteimageP, Convert.ToInt32(comboCatArt.SelectedValue));
                        MessageBox.Show("Article modifié !","Modification",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //Actualiser datagrid
                        (usarticle as USR_Article).Actualiserdgv();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Modification annulée !", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            }

        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            //Choisir une image dans un fichier
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "(*.jpg)|*.jpg| (*.gif)|*.gif| (*.png)|*.png| (*.bmp)|*.bmp| (*.jpeg)|*.jpeg"; //Affiche les fichiers images
            if (OP.ShowDialog() == DialogResult.OK)
            {
                picArt.Image = Image.FromFile(OP.FileName);
            }

        }

        private void textQteArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57) //code asci des n°{
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void textPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57) 
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if( e.KeyChar == 44 || e.KeyChar == 46) //code asci des n° et . et ,)
            {
                e.Handled= false;
            }

        }
    }
}
