using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CatalogService.Data
{
    public partial class CatalogContext : DbContext
    {
        public CatalogContext()
        {
        }

        public CatalogContext(DbContextOptions<CatalogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Orders> Orders1 { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Street> Streets { get; set; }
        public virtual DbSet<SuplProduct> SuplProducts { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Town> Towns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Catalog;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Adress)
                    .HasMaxLength(15)
                    .IsFixedLength(true);

                entity.Property(e => e.FatherName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Login)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.SecondName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.StreetNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.Street)
                    .HasConstraintName("FK_Clients_Streets");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Order");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Orders");

                entity.HasOne(d => d.Item)
                    .WithMany()
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_Order_Products");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.ToTable("Orders");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DataReceave).HasColumnType("date");

                entity.Property(e => e.DateCreate).HasColumnType("date");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Order1s)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Orders_Clients");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Characteristics)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.GroupNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Group)
                    .HasConstraintName("FK_Products_Groups");
            });

            modelBuilder.Entity<Street>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.TownNavigation)
                    .WithMany(p => p.Streets)
                    .HasForeignKey(d => d.Town)
                    .HasConstraintName("FK_Streets_Towns");
            });

            modelBuilder.Entity<SuplProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SuplProduct");

                entity.Property(e => e.Idproduct).HasColumnName("IDProduct");

                entity.Property(e => e.Idsupplier).HasColumnName("IDSupplier");

                entity.HasOne(d => d.IdproductNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idproduct)
                    .HasConstraintName("FK_SuplProduct_Products");

                entity.HasOne(d => d.IdsupplierNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idsupplier)
                    .HasConstraintName("FK_SuplProduct_Suppliers");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.StreetNavigation)
                    .WithMany(p => p.Suppliers)
                    .HasForeignKey(d => d.Street)
                    .HasConstraintName("FK_Suppliers_Streets");
            });

            modelBuilder.Entity<Town>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.Towns)
                    .HasForeignKey(d => d.Country)
                    .HasConstraintName("FK_Towns_Countries");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
