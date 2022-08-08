using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Entidades
{
    public partial class DB_EMPRESA_AUTOBUSERAContext : DbContext
    {
        public DB_EMPRESA_AUTOBUSERAContext()
        {
        }

        public DB_EMPRESA_AUTOBUSERAContext(DbContextOptions<DB_EMPRESA_AUTOBUSERAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblChofere> TblChoferes { get; set; }
        public virtual DbSet<TblEstado> TblEstados { get; set; }
        public virtual DbSet<TblPerfile> TblPerfiles { get; set; }
        public virtual DbSet<TblRutum> TblRuta { get; set; }
        public virtual DbSet<TblUsuario> TblUsuarios { get; set; }
        public virtual DbSet<TblVehiculo> TblVehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-7IREEGO6;Database=DB_EMPRESA_AUTOBUSERA;Persist Security info=true; user id=sa; password=12345678;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<TblChofere>(entity =>
            {
                entity.HasKey(e => e.IdChoferes)
                    .HasName("PK_CHOFERES");

                entity.ToTable("TBL_CHOFERES", "SCH_PROCESO");

                entity.Property(e => e.IdChoferes)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_CHOFERES");

                entity.Property(e => e.Edad)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("EDAD");

                entity.Property(e => e.IdEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ID_ESTADO")
                    .IsFixedLength(true);

                entity.Property(e => e.IdVehiculo).HasColumnName("ID_VEHICULO");

                entity.Property(e => e.Identidad)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDENTIDAD");

                entity.Property(e => e.NombreApellidos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_APELLIDOS");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TblChoferes)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CHOFERES_ESTADOS_ID_ESTADO");

                entity.HasOne(d => d.IdVehiculoNavigation)
                    .WithMany(p => p.TblChoferes)
                    .HasForeignKey(d => d.IdVehiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CHOFERES_VEHICULO_ID_VEHICULO");
            });

            modelBuilder.Entity<TblEstado>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PK_ESTADOS");

                entity.ToTable("TBL_ESTADOS", "SCH_ADMINISTRACION");

                entity.Property(e => e.IdEstado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ID_ESTADO")
                    .IsFixedLength(true);

                entity.Property(e => e.DescEstado)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DESC_ESTADO");
            });

            modelBuilder.Entity<TblPerfile>(entity =>
            {
                entity.HasKey(e => e.IdPerfil)
                    .HasName("PK_PERFILES");

                entity.ToTable("TBL_PERFILES", "SCH_ADMINISTRACION");

                entity.Property(e => e.IdPerfil)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_PERFIL");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.IdEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ID_ESTADO")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TblPerfiles)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERFILES_ESTADOS_ID_ESTADOS");
            });

            modelBuilder.Entity<TblRutum>(entity =>
            {
                entity.HasKey(e => e.IdRuta)
                    .HasName("PK_RUTA");

                entity.ToTable("TBL_RUTA", "SCH_PROCESO");

                entity.Property(e => e.IdRuta)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_RUTA");

                entity.Property(e => e.DescripcionRuta)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_RUTA");

                entity.Property(e => e.IdChoferes).HasColumnName("ID_CHOFERES");

                entity.Property(e => e.IdEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ID_ESTADO")
                    .IsFixedLength(true);

                entity.Property(e => e.MontoFinal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MONTO_FINAL");

                entity.Property(e => e.MontoInicial)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MONTO_INICIAL");

                entity.Property(e => e.Paradas).HasColumnName("PARADAS");

                entity.HasOne(d => d.IdChoferesNavigation)
                    .WithMany(p => p.TblRuta)
                    .HasForeignKey(d => d.IdChoferes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RUTA_CHOFERES_ID_CHOFERES");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TblRuta)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RUTA_ESTADOS_ID_ESTADO");
            });

            modelBuilder.Entity<TblUsuario>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK_USUARIOS");

                entity.ToTable("TBL_USUARIOS", "SCH_ADMINISTRACION");

                entity.Property(e => e.Username)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CONTRASENA");

                entity.Property(e => e.IdEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ID_ESTADO")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPerfil).HasColumnName("ID_PERFIL");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TblUsuarios)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIOS_ESTADOS_ID_ESTADO");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.TblUsuarios)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIOS_PERFILES_ID_PERFIL");
            });

            modelBuilder.Entity<TblVehiculo>(entity =>
            {
                entity.HasKey(e => e.IdVehiculo)
                    .HasName("PK_VEHICULOS");

                entity.ToTable("TBL_VEHICULOS", "SCH_PROCESO");

                entity.Property(e => e.IdVehiculo)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_VEHICULO");

                entity.Property(e => e.AñoFabricacion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("AÑO_FABRICACION")
                    .IsFixedLength(true);

                entity.Property(e => e.Fabricante)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FABRICANTE");

                entity.Property(e => e.IdEstado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ID_ESTADO")
                    .IsFixedLength(true);

                entity.Property(e => e.PlacaVehiculo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PLACA_VEHICULO")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TblVehiculos)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEHICULOS_ESTADOS_ID_ESTADO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
