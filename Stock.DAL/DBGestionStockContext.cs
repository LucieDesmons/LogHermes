using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GestionStock.DAL
{
    public partial class DBGestionStockContext : DbContext
    {
        public DBGestionStockContext()
        {
        }

        public DBGestionStockContext(DbContextOptions<DBGestionStockContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorie> Categories { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Commande> Commandes { get; set; } = null!;
        public virtual DbSet<DetailsCommande> DetailsCommandes { get; set; } = null!;
        public virtual DbSet<Produit> Produits { get; set; } = null!;
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-SJ53C7G\\SQLEXPRESS ;user id= sa ; password= Lucie ;Initial Catalog= GESTION_STOCK ;");
            }
        }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.HasKey(e => e.IdCategorie);

                entity.ToTable("CATEGORIE");

                entity.Property(e => e.IdCategorie).HasColumnName("Id_Categorie");

                entity.Property(e => e.NomCategorie)
                    .HasMaxLength(250)
                    .HasColumnName("Nom_Categorie");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient);

                entity.ToTable("CLIENT");

                entity.Property(e => e.IdClient).HasColumnName("Id_Client");

                entity.Property(e => e.AdresseClient)
                    .HasMaxLength(250)
                    .HasColumnName("Adresse_Client");

                entity.Property(e => e.EmailClient)
                    .HasMaxLength(250)
                    .HasColumnName("Email_Client");

                entity.Property(e => e.NomClient)
                    .HasMaxLength(250)
                    .HasColumnName("Nom_Client");

                entity.Property(e => e.PaysClient)
                    .HasMaxLength(250)
                    .HasColumnName("Pays_Client");

                entity.Property(e => e.PrenomClient)
                    .HasMaxLength(250)
                    .HasColumnName("Prenom_Client");

                entity.Property(e => e.TelephoneClient)
                    .HasMaxLength(250)
                    .HasColumnName("Telephone_Client");

                entity.Property(e => e.VilleClient)
                    .HasMaxLength(250)
                    .HasColumnName("Ville_Client");
            });

            modelBuilder.Entity<Commande>(entity =>
            {
                entity.HasKey(e => e.IdCommande);

                entity.ToTable("COMMANDE");

                entity.Property(e => e.IdCommande).HasColumnName("Id_Commande");

                entity.Property(e => e.DateCommande)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Commande");

                entity.Property(e => e.IdClient).HasColumnName("Id_Client");

                entity.Property(e => e.TotalHt)
                    .HasMaxLength(250)
                    .HasColumnName("Total_HT");

                entity.Property(e => e.TotalTtc)
                    .HasMaxLength(250)
                    .HasColumnName("Total_TTC");

                entity.Property(e => e.Tva)
                    .HasMaxLength(20)
                    .HasColumnName("TVA");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("FK_COMMANDE_CLIENT");
            });

            modelBuilder.Entity<DetailsCommande>(entity =>
            {
                entity.HasKey(e => e.IdDetail)
                    .HasName("PK__Details___BA1D96E4BEB61D97");

                entity.ToTable("Details_Commande");

                entity.Property(e => e.IdCommande).HasColumnName("Id_Commande");

                entity.Property(e => e.IdProduit).HasColumnName("Id_Produit");

                entity.Property(e => e.NomProduit).HasMaxLength(250);

                entity.Property(e => e.Prix).HasMaxLength(250);

                entity.Property(e => e.Remise).HasMaxLength(250);

                entity.Property(e => e.Total).HasMaxLength(250);

                entity.HasOne(d => d.IdCommandeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCommande)
                    .HasConstraintName("FK_Details_Commande_COMMANDE");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdProduit)
                    .HasConstraintName("FK_Details_Commande_PRODUIT");
            });

            modelBuilder.Entity<Produit>(entity =>
            {
                entity.HasKey(e => e.IdProduit);

                entity.ToTable("PRODUIT");

                entity.Property(e => e.IdProduit).HasColumnName("Id_Produit");

                entity.Property(e => e.IdCategorie).HasColumnName("Id_Categorie");

                entity.Property(e => e.ImageProduit)
                    .HasColumnType("image")
                    .HasColumnName("Image_Produit");

                entity.Property(e => e.NomProduit)
                    .HasMaxLength(250)
                    .HasColumnName("Nom_Produit");

                entity.Property(e => e.AnneeProduit)
                    .HasMaxLength(250)
                    .HasColumnName("Annee_Produit");

                entity.Property(e => e.DescriptionProduit)
                    .HasMaxLength(250)
                    .HasColumnName("Description_Produit");

                entity.Property(e => e.PrixProduit)
                    .HasColumnType("money")
                    .HasColumnName("Prix_Produit");

                entity.Property(e => e.PrixCartonProduit)
                    .HasColumnType("money")
                    .HasColumnName("Prix_Carton_Produit");

                entity.Property(e => e.QuantiteProduit).HasColumnName("Quantite_Produit");

                entity.HasOne(d => d.IdCategorieNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCategorie)
                    .HasConstraintName("FK_PRODUIT_CATEGORIE");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.HasKey(e => e.NomUtilisateur);

                entity.ToTable("UTILISATEUR");

                entity.Property(e => e.NomUtilisateur)
                    .HasMaxLength(250)
                    .HasColumnName("Nom_Utilisateur");

                entity.Property(e => e.MotDePasse)
                    .HasMaxLength(250)
                    .HasColumnName("Mot_de_passe");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
