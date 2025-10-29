using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GestionF1.Data.Entidades;

public partial class GestionF1Context : DbContext
{
    public GestionF1Context()
    {
    }

    public GestionF1Context(DbContextOptions<GestionF1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Escuderium> Escuderia { get; set; }

    public virtual DbSet<Piloto> Pilotos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=GestionF1;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Escuderium>(entity =>
        {
            entity.HasKey(e => e.IdEscuderia);

            entity.Property(e => e.NombreEscuderia).HasMaxLength(100);
        });

        modelBuilder.Entity<Piloto>(entity =>
        {
            entity.HasKey(e => e.IdPiloto);

            entity.ToTable("Piloto");

            entity.Property(e => e.NombrePiloto).HasMaxLength(100);

            entity.HasOne(d => d.IdEscuderiaNavigation).WithMany(p => p.Pilotos)
                .HasForeignKey(d => d.IdEscuderia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Piloto_Escuderia");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
