using Data.ModelData;
using Microsoft.EntityFrameworkCore;

namespace Data.ModelData
{
    public partial class SpDbContext : DbContext
    {
        public SpDbContext()
        {
        }

        public SpDbContext(DbContextOptions<SpDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Provedor> Provedors { get; set; } = null!;
        public virtual DbSet<TelefonoCliente> TelefonoClientes { get; set; } = null!;
        public virtual DbSet<TelefonoProvedor> TelefonoProvedors { get; set; } = null!;
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; } = null!;
        public virtual DbSet<TipoTelefono> TipoTelefonos { get; set; } = null!;
        public virtual DbSet<Ventum> Venta { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cliente_tipo_documento");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdProvedorNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdProvedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_producto_provedor");
            });

            modelBuilder.Entity<Provedor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TelefonoCliente>(entity =>
            {
                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_telefono_cliente_cliente");

                entity.HasOne(d => d.IdTipoTelefonoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdTipoTelefono)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_telefono_cliente_tipo_telefono");
            });

            modelBuilder.Entity<TelefonoProvedor>(entity =>
            {
                entity.HasOne(d => d.IdProvedorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdProvedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_telefono_provedor_provedor");

                entity.HasOne(d => d.IdTipoTelefonoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdTipoTelefono)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_telefono_provedor_tipo_telefono");
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TipoTelefono>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Ventum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_venta_cliente");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
