using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Stock.DAL
{
    public partial class DBLogHermesContext : DbContext
    {
        //public DBLogHermesContext()
        //{
        //}

        public DBLogHermesContext(DbContextOptions<DBLogHermesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; } = null!;
        public virtual DbSet<Categorie> Categories { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<CmdClient> CmdClients { get; set; } = null!;
        public virtual DbSet<CmdFournisseur> CmdFournisseurs { get; set; } = null!;
        public virtual DbSet<Correspondre> Correspondres { get; set; } = null!;
        public virtual DbSet<EmplacementStock> EmplacementStocks { get; set; } = null!;
        public virtual DbSet<Employe> Employes { get; set; } = null!;
        public virtual DbSet<Facture> Factures { get; set; } = null!;
        public virtual DbSet<Fournisseur> Fournisseurs { get; set; } = null!;
        public virtual DbSet<Receptionner> Receptionners { get; set; } = null!;
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-SJ53C7G\SQLEXPRESS;user id=Lucie; password=Lucie;Initial Catalog=DBLogHermes;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(entity =>
            {
                entity.ToTable("ARTICLE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Annee)
                    .HasColumnType("date")
                    .HasColumnName("annee");

                entity.Property(e => e.Cepage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cepage");

                entity.Property(e => e.Description)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Id1).HasColumnName("id_1");

                entity.Property(e => e.Image)
                    .HasMaxLength(350)
                    .HasColumnName("image")
                    .IsFixedLength();

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nom");

                entity.Property(e => e.Note)
                    .HasColumnType("decimal(2, 2)")
                    .HasColumnName("note");

                entity.Property(e => e.Prix)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("prix");

                entity.Property(e => e.Quantite).HasColumnName("quantite");

                entity.Property(e => e.Taxe)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("taxe");

                entity.HasOne(d => d.Id1Navigation)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.Id1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ARTICLE__id_1__36B12243");

                entity.HasMany(d => d.Id1s)
                    .WithMany(p => p.Ids)
                    .UsingEntity<Dictionary<string, object>>(
                        "Contenir",
                        l => l.HasOne<EmplacementStock>().WithMany().HasForeignKey("Id1").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Contenir__id_1__4CA06362"),
                        r => r.HasOne<Article>().WithMany().HasForeignKey("Id").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Contenir__id__4BAC3F29"),
                        j =>
                        {
                            j.HasKey("Id", "Id1").HasName("PK__Contenir__6BC89515D75B7C29");

                            j.ToTable("Contenir");

                            j.IndexerProperty<int>("Id").HasColumnName("id");

                            j.IndexerProperty<int>("Id1").HasColumnName("id_1");
                        });

                entity.HasMany(d => d.Id1sNavigation)
                    .WithMany(p => p.Ids1)
                    .UsingEntity<Dictionary<string, object>>(
                        "Enregistrer",
                        l => l.HasOne<Employe>().WithMany().HasForeignKey("Id1").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Enregistre__id_1__5BE2A6F2"),
                        r => r.HasOne<Article>().WithMany().HasForeignKey("Id").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Enregistrer__id__5AEE82B9"),
                        j =>
                        {
                            j.HasKey("Id", "Id1").HasName("PK__Enregist__6BC89515E9B0FCD9");

                            j.ToTable("Enregistrer");

                            j.IndexerProperty<int>("Id").HasColumnName("id");

                            j.IndexerProperty<int>("Id1").HasColumnName("id_1");
                        });
            });

            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.ToTable("CATEGORIE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Nature)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nature");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nom");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("CLIENT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CodePostal).HasColumnName("codePostal");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Id1).HasColumnName("id_1");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nom");

                entity.Property(e => e.NumSiret)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("num_siret");

                entity.Property(e => e.NumTva)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("num_TVA");

                entity.Property(e => e.Pays)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pays");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prenom");

                entity.Property(e => e.Rue)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("rue");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("telephone");

                entity.Property(e => e.Ville)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ville");

                entity.HasOne(d => d.Id1Navigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.Id1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CLIENT__id_1__398D8EEE");

                entity.HasMany(d => d.Id1s)
                    .WithMany(p => p.Ids2)
                    .UsingEntity<Dictionary<string, object>>(
                        "Inscrire",
                        l => l.HasOne<Employe>().WithMany().HasForeignKey("Id1").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Inscrire__id_1__5441852A"),
                        r => r.HasOne<Client>().WithMany().HasForeignKey("Id").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Inscrire__id__534D60F1"),
                        j =>
                        {
                            j.HasKey("Id", "Id1").HasName("PK__Inscrire__6BC8951525E9FA03");

                            j.ToTable("Inscrire");

                            j.IndexerProperty<int>("Id").HasColumnName("id");

                            j.IndexerProperty<int>("Id1").HasColumnName("id_1");
                        });
            });

            modelBuilder.Entity<CmdClient>(entity =>
            {
                entity.ToTable("CMD_CLIENT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateCmd)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCmd");

                entity.Property(e => e.DateLivraison)
                    .HasColumnType("date")
                    .HasColumnName("dateLivraison");

                entity.Property(e => e.Devise)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("devise");

                entity.Property(e => e.Etat)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("etat");

                entity.Property(e => e.Libelle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("libelle");

                entity.Property(e => e.LieuLivraison)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lieuLivraison");

                entity.Property(e => e.ModePaiement)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("modePaiement");

                entity.Property(e => e.MontantCmd)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("montantCmd");
            });

            modelBuilder.Entity<CmdFournisseur>(entity =>
            {
                entity.ToTable("CMD_FOURNISSEUR");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateCmd)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCmd");

                entity.Property(e => e.DateLivraison)
                    .HasColumnType("datetime")
                    .HasColumnName("dateLivraison");

                entity.Property(e => e.Libelle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("libelle");

                entity.Property(e => e.ModePaiement)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("modePaiement");

                entity.Property(e => e.MontantCmd)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("montantCmd");

                entity.Property(e => e.PrixAchatHt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("prixAchatHT");

                entity.Property(e => e.Taxe)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("taxe");
            });

            modelBuilder.Entity<Correspondre>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Id1 })
                    .HasName("PK__Correspo__6BC89515B6C4D951");

                entity.ToTable("Correspondre");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Id1).HasColumnName("id_1");

                entity.Property(e => e.PrixVente)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("prixVente");

                entity.Property(e => e.SortieStock).HasColumnName("sortieStock");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Correspondres)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Correspondre__id__440B1D61");

                entity.HasOne(d => d.Id1Navigation)
                    .WithMany(p => p.Correspondres)
                    .HasForeignKey(d => d.Id1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Correspond__id_1__44FF419A");
            });

            modelBuilder.Entity<EmplacementStock>(entity =>
            {
                entity.ToTable("EMPLACEMENT_STOCK");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.NumCasier).HasColumnName("numCasier");

                entity.Property(e => e.NumRang).HasColumnName("numRang");
            });

            modelBuilder.Entity<Employe>(entity =>
            {
                entity.ToTable("EMPLOYE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nom");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prenom");

                entity.Property(e => e.Role)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("role");

                entity.HasMany(d => d.Id1s)
                    .WithMany(p => p.IdsNavigation)
                    .UsingEntity<Dictionary<string, object>>(
                        "Organiser",
                        l => l.HasOne<EmplacementStock>().WithMany().HasForeignKey("Id1").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Organiser__id_1__5070F446"),
                        r => r.HasOne<Employe>().WithMany().HasForeignKey("Id").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Organiser__id__4F7CD00D"),
                        j =>
                        {
                            j.HasKey("Id", "Id1").HasName("PK__Organise__6BC8951518A76114");

                            j.ToTable("Organiser");

                            j.IndexerProperty<int>("Id").HasColumnName("id");

                            j.IndexerProperty<int>("Id1").HasColumnName("id_1");
                        });

                entity.HasMany(d => d.Id1sNavigation)
                    .WithMany(p => p.IdsNavigation)
                    .UsingEntity<Dictionary<string, object>>(
                        "Réaliser",
                        l => l.HasOne<CmdFournisseur>().WithMany().HasForeignKey("Id1").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Réaliser__id_1__5FB337D6"),
                        r => r.HasOne<Employe>().WithMany().HasForeignKey("Id").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Réaliser__id__5EBF139D"),
                        j =>
                        {
                            j.HasKey("Id", "Id1").HasName("PK__Réaliser__6BC89515174D4FB1");

                            j.ToTable("Réaliser");

                            j.IndexerProperty<int>("Id").HasColumnName("id");

                            j.IndexerProperty<int>("Id1").HasColumnName("id_1");
                        });
            });

            modelBuilder.Entity<Facture>(entity =>
            {
                entity.ToTable("FACTURE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateFacture)
                    .HasColumnType("datetime")
                    .HasColumnName("dateFacture");

                entity.Property(e => e.Id1).HasColumnName("id_1");

                entity.Property(e => e.Libelle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("libelle");

                entity.Property(e => e.Montant)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("montant");

                entity.HasOne(d => d.Id1Navigation)
                    .WithMany(p => p.Factures)
                    .HasForeignKey(d => d.Id1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FACTURE__id_1__2A4B4B5E");

                entity.HasMany(d => d.Id1s)
                    .WithMany(p => p.IdsNavigation)
                    .UsingEntity<Dictionary<string, object>>(
                        "Editer",
                        l => l.HasOne<Employe>().WithMany().HasForeignKey("Id1").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Editer__id_1__48CFD27E"),
                        r => r.HasOne<Facture>().WithMany().HasForeignKey("Id").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Editer__id__47DBAE45"),
                        j =>
                        {
                            j.HasKey("Id", "Id1").HasName("PK__Editer__6BC89515AF141620");

                            j.ToTable("Editer");

                            j.IndexerProperty<int>("Id").HasColumnName("id");

                            j.IndexerProperty<int>("Id1").HasColumnName("id_1");
                        });
            });

            modelBuilder.Entity<Fournisseur>(entity =>
            {
                entity.ToTable("FOURNISSEUR");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CodePostal).HasColumnName("codePostal");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nom");

                entity.Property(e => e.NumSiret)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("num_siret");

                entity.Property(e => e.NumTva)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("num_TVA");

                entity.Property(e => e.Pays)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pays");

                entity.Property(e => e.Rue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rue");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("telephone");

                entity.Property(e => e.Ville)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ville");

                entity.HasMany(d => d.Id1s)
                    .WithMany(p => p.Ids)
                    .UsingEntity<Dictionary<string, object>>(
                        "Créer",
                        l => l.HasOne<Employe>().WithMany().HasForeignKey("Id1").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Créer__id_1__5812160E"),
                        r => r.HasOne<Fournisseur>().WithMany().HasForeignKey("Id").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Créer__id__571DF1D5"),
                        j =>
                        {
                            j.HasKey("Id", "Id1").HasName("PK__Créer__6BC89515D0C0851C");

                            j.ToTable("Créer");

                            j.IndexerProperty<int>("Id").HasColumnName("id");

                            j.IndexerProperty<int>("Id1").HasColumnName("id_1");
                        });

                entity.HasMany(d => d.Id1sNavigation)
                    .WithMany(p => p.Ids)
                    .UsingEntity<Dictionary<string, object>>(
                        "Livrer",
                        l => l.HasOne<CmdFournisseur>().WithMany().HasForeignKey("Id1").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Livrer__id_1__412EB0B6"),
                        r => r.HasOne<Fournisseur>().WithMany().HasForeignKey("Id").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Livrer__id__403A8C7D"),
                        j =>
                        {
                            j.HasKey("Id", "Id1").HasName("PK__Livrer__6BC89515572A9E3D");

                            j.ToTable("Livrer");

                            j.IndexerProperty<int>("Id").HasColumnName("id");

                            j.IndexerProperty<int>("Id1").HasColumnName("id_1");
                        });
            });

            modelBuilder.Entity<Receptionner>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Id1 })
                    .HasName("PK__Receptio__6BC8951514B79B67");

                entity.ToTable("Receptionner");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Id1).HasColumnName("id_1");

                entity.Property(e => e.EntreeStock).HasColumnName("entreeStock");

                entity.Property(e => e.PrixAchat)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("prixAchat");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Receptionners)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Receptionner__id__3C69FB99");

                entity.HasOne(d => d.Id1Navigation)
                    .WithMany(p => p.Receptionners)
                    .HasForeignKey(d => d.Id1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Receptionn__id_1__3D5E1FD2");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.ToTable("UTILISATEUR");

                entity.HasIndex(e => e.Id1, "UQ__UTILISAT__9DB7D2A55BEC1EE9")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Id1).HasColumnName("id_1");

                entity.Property(e => e.MotDePasse)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mot_de_passe");

                entity.Property(e => e.NomUtilisateur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomUtilisateur");

                entity.HasOne(d => d.Id1Navigation)
                    .WithOne(p => p.Utilisateur)
                    .HasForeignKey<Utilisateur>(d => d.Id1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UTILISATEU__id_1__33D4B598");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
