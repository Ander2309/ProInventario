using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProInventario.Contexto;

public partial class InventarioContext : DbContext
{
    public InventarioContext()
    {
    }

    public InventarioContext(DbContextOptions<InventarioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<DetallesInventario> DetallesInventarios { get; set; }

    public virtual DbSet<DetallesReporte> DetallesReportes { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Reporte> Reportes { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-KTID0VJ;Initial Catalog=Inventario;Integrated Security=True; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.CategoriaId).HasName("PK__Categori__F353C1C50666065C");

            entity.Property(e => e.CategoriaId)
                .ValueGeneratedNever()
                .HasColumnName("CategoriaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DetallesInventario>(entity =>
        {
            entity.HasKey(e => e.DetalleId).HasName("PK__Detalles__6E19D6FA48FE86EC");

            entity.ToTable("DetallesInventario");

            entity.Property(e => e.DetalleId)
                .ValueGeneratedNever()
                .HasColumnName("DetalleID");
            entity.Property(e => e.InventarioId).HasColumnName("InventarioID");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");

            entity.HasOne(d => d.Inventario).WithMany(p => p.DetallesInventarios)
                .HasForeignKey(d => d.InventarioId)
                .HasConstraintName("FK__DetallesI__Inven__4222D4EF");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetallesInventarios)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK__DetallesI__Produ__4316F928");
        });

        modelBuilder.Entity<DetallesReporte>(entity =>
        {
            entity.HasKey(e => e.DetalleReporteId).HasName("PK__Detalles__FFEA08BFADE8193D");

            entity.ToTable("DetallesReporte");

            entity.Property(e => e.DetalleReporteId)
                .ValueGeneratedNever()
                .HasColumnName("DetalleReporteID");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.ReporteId).HasColumnName("ReporteID");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetallesReportes)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK__DetallesR__Produ__49C3F6B7");

            entity.HasOne(d => d.Reporte).WithMany(p => p.DetallesReportes)
                .HasForeignKey(d => d.ReporteId)
                .HasConstraintName("FK__DetallesR__Repor__48CFD27E");
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.InventarioId).HasName("PK__Inventar__FB8A24B7E6F9C87F");

            entity.Property(e => e.InventarioId)
                .ValueGeneratedNever()
                .HasColumnName("InventarioID");
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Inventari__UserI__3F466844");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__Producto__A430AE833AE21CDF");

            entity.Property(e => e.ProductoId)
                .ValueGeneratedNever()
                .HasColumnName("ProductoID");
            entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Categoria).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoriaId)
                .HasConstraintName("FK__Productos__Categ__3C69FB99");
        });

        modelBuilder.Entity<Reporte>(entity =>
        {
            entity.HasKey(e => e.ReporteId).HasName("PK__Reportes__0B29EA4E39696B18");

            entity.Property(e => e.ReporteId)
                .ValueGeneratedNever()
                .HasColumnName("ReporteID");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Reportes)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__Reportes__Usuari__45F365D3");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Usuarios__1788CCACF599960F");

            entity.HasIndex(e => e.CorreoElectronico, "UQ__Usuarios__531402F3C4C59D83").IsUnique();

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rol)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
