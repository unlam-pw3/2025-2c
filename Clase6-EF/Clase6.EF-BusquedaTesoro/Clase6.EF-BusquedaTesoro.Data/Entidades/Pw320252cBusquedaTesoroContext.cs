using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Clase6.EF_BusquedaTesoro.Data.Entidades;

public partial class Pw320252cBusquedaTesoroContext : DbContext
{
    public Pw320252cBusquedaTesoroContext()
    {
    }

    public Pw320252cBusquedaTesoroContext(DbContextOptions<Pw320252cBusquedaTesoroContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tesoro> Tesoros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=PW3-2025-2c-BusquedaTesoro;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tesoro>(entity =>
        {
            entity.HasKey(e => e.IdTesoro);

            entity.ToTable("Tesoro");

            entity.Property(e => e.ImagenUrl).HasMaxLength(1000);
            entity.Property(e => e.Latitud).HasColumnType("decimal(9, 6)");
            entity.Property(e => e.Longitud).HasColumnType("decimal(9, 6)");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
