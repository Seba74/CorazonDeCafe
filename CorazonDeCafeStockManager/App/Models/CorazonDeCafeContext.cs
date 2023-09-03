using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CorazonDeCafeStockManager.App.Models;

public partial class CorazonDeCafeContext : DbContext
{
    public CorazonDeCafeContext() { }

    public CorazonDeCafeContext(DbContextOptions<CorazonDeCafeContext> options) : base(options){}

    public virtual DbSet<Cart>? Carts { get; set; }

    public virtual DbSet<CartProducto>? CartProductos { get; set; }

    public virtual DbSet<Categoria>? Categorias { get; set; }

    public virtual DbSet<Domicilio>? Domicilios { get; set; }

    public virtual DbSet<Product>? Products { get; set; }

    public virtual DbSet<Role>? Roles { get; set; }

    public virtual DbSet<Tipo>? Tipos { get; set; }

    public virtual DbSet<Usuario>? Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cart_id");

            entity.ToTable("cart", "db_guevara_johan");

            entity.HasIndex(e => e.UsuarioId, "usuario_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasMaxLength(255)
                .HasColumnName("estado");
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");
            entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Carts)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("cart$cart_ibfk_1");
        });

        modelBuilder.Entity<CartProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cart_productos_id");

            entity.ToTable("cart_productos", "db_guevara_johan");

            entity.HasIndex(e => e.CartId, "cart_id");

            entity.HasIndex(e => e.ProductId, "product_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.CartId).HasColumnName("cart_id");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("precio");
            entity.Property(e => e.ProductId).HasColumnName("product_id");

            entity.HasOne(d => d.Cart).WithMany(p => p.CartProductos)
                .HasForeignKey(d => d.CartId)
                .HasConstraintName("cart_productos$cart_productos_ibfk_1");

            entity.HasOne(d => d.Product).WithMany(p => p.CartProductos)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("cart_productos$cart_productos_ibfk_2");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_categorias_id");

            entity.ToTable("categorias", "db_guevara_johan");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activo)
                .HasMaxLength(2)
                .HasColumnName("activo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Domicilio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_domicilios_id");

            entity.ToTable("domicilios", "db_guevara_johan");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calle)
                .HasMaxLength(50)
                .HasColumnName("calle");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(30)
                .HasColumnName("ciudad");
            entity.Property(e => e.CodigoPostal).HasColumnName("codigo_postal");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Pais)
                .HasMaxLength(30)
                .HasColumnName("pais");
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_products_id");

            entity.ToTable("products", "db_guevara_johan");

            entity.HasIndex(e => e.CategoriaId, "categoria_id");

            entity.HasIndex(e => e.TipoId, "tipo_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoriaId).HasColumnName("categoria_id");
            entity.Property(e => e.Estado)
                .HasMaxLength(2)
                .HasColumnName("estado");
            entity.Property(e => e.Imagen)
                .HasMaxLength(50)
                .HasColumnName("imagen");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio).HasColumnName("precio");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.TipoId).HasColumnName("tipo_id");

            entity.HasOne(d => d.Categoria).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("products$products_ibfk_1");

            entity.HasOne(d => d.Tipo).WithMany(p => p.Products)
                .HasForeignKey(d => d.TipoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("products$products_ibfk\n_2");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_roles_id");

            entity.ToTable("roles", "db_guevara_johan");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activo)
                .HasMaxLength(2)
                .HasColumnName("activo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Tipo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tipos_id");

            entity.ToTable("tipos", "db_guevara_johan");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activo)
                .HasMaxLength(2)
                .HasColumnName("activo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_usuarios_id");

            entity.ToTable("usuarios", "db_guevara_johan");

            entity.HasIndex(e => e.RoleId, "role_id");

            entity.HasIndex(e => e.Email, "usuarios$email").IsUnique();

            entity.HasIndex(e => e.Usuario1, "usuarios$usuario").IsUnique();

            entity.HasIndex(e => e.DomicilioId, "usuarios_ibfk_1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(30)
                .HasColumnName("apellido");
            entity.Property(e => e.Baja)
                .HasMaxLength(2)
                .HasColumnName("baja");
            entity.Property(e => e.DomicilioId).HasColumnName("domicilio_id");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .HasColumnName("nombre");
            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .HasColumnName("pass");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(20)
                .HasColumnName("usuario");

            entity.HasOne(d => d.Domicilio).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.DomicilioId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("usuarios$usuarios_ibfk_1");

            entity.HasOne(d => d.Role).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("usuarios$usuarios_ibfk_2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
