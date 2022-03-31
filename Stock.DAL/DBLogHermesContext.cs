using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Stock.DAL
{
    public partial class DBLogHermesContext : DbContext
    {
        public DBLogHermesContext()
        {
        }

        public DBLogHermesContext(DbContextOptions<DBLogHermesContext> options)
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
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-SJ53C7G\SQLEXPRESS;user id=Lucie; password=Lucie;Initial Catalog=DBLogHermes;");
            }
        }

    };
}