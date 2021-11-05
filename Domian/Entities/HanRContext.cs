using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Proyecto_Artesanos.Domian.Entities
{
    public partial class HanRContext : DbContext
    {
        public HanRContext()
        {
        }

        public HanRContext(DbContextOptions<HanRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Artesano> Artesanos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=Proyecto_Artesanos");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Artesano>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Asociacion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IdArtesano).HasColumnName("ID_Artesano");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Producto");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");

                entity.Property(e => e.NombreArtesania)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Nombre_Artesania");

                entity.Property(e => e.TipoMaterial)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Tipo_Material");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
