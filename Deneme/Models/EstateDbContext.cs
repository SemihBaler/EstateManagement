using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Deneme.Models;

public partial class EstateDbContext : DbContext
{
    public EstateDbContext()
    {
    }

    public EstateDbContext(DbContextOptions<EstateDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adress> Adresses { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Estate> Estates { get; set; }

    public virtual DbSet<EstateType> EstateTypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localDb)\\MSSQLLocalDb;Database=EstateDb;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Adress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_YeniAdresTablosu");

            entity.ToTable("Adress");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MahalleId).HasColumnName("MahalleID");
            entity.Property(e => e.Maxlatitude).HasColumnName("maxlatitude");
            entity.Property(e => e.Maxlongitude).HasColumnName("maxlongitude");
            entity.Property(e => e.Minlatitude).HasColumnName("minlatitude");
            entity.Property(e => e.Minlongitude).HasColumnName("minlongitude");
            entity.Property(e => e.UstId).HasColumnName("UstID");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_Customers_CategoryId");

            entity.HasIndex(e => e.EstateTypeId, "IX_Customers_EstateTypeId");

            entity.HasIndex(e => e.TypeId, "IX_Customers_TypeId");

            entity.HasOne(d => d.Category).WithMany(p => p.Customers).HasForeignKey(d => d.CategoryId);

            entity.HasOne(d => d.EstateType).WithMany(p => p.Customers).HasForeignKey(d => d.EstateTypeId);

            entity.HasOne(d => d.Type).WithMany(p => p.Customers).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<Estate>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_Estates_CategoryId");

            entity.HasIndex(e => e.EstateTypeId, "IX_Estates_EstateTypeId");

            entity.HasOne(d => d.Category).WithMany(p => p.Estates).HasForeignKey(d => d.CategoryId);

            entity.HasOne(d => d.EstateType).WithMany(p => p.Estates).HasForeignKey(d => d.EstateTypeId);
        });

        modelBuilder.Entity<EstateType>(entity =>
        {
            entity.ToTable("EstateType");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
