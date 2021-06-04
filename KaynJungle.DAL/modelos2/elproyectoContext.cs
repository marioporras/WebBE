using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KaynJungle.DAL.modelos2
{
    public partial class elproyectoContext : DbContext
    {
        public elproyectoContext()
        {
        }

        public elproyectoContext(DbContextOptions<elproyectoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Concesionario> Concesionario { get; set; }
        public virtual DbSet<Jefemecanico> Jefemecanico { get; set; }
        public virtual DbSet<Mecanico> Mecanico { get; set; }
        public virtual DbSet<Pieza> Pieza { get; set; }
        public virtual DbSet<Propuestas> Propuestas { get; set; }
        public virtual DbSet<Reparacion> Reparacion { get; set; }
        public virtual DbSet<Trabajodia> Trabajodia { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Vehiculo> Vehiculo { get; set; }
        public virtual DbSet<Vehiculosvendidos> Vehiculosvendidos { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=123456;database=elproyecto");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.ToTable("cliente");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("idCliente_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdCliente)
                    .HasColumnName("idCliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos")
                    .HasMaxLength(45);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasColumnName("dni")
                    .HasMaxLength(11);

                entity.Property(e => e.FechaAlta)
                    .IsRequired()
                    .HasColumnName("fechaAlta")
                    .HasMaxLength(15);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(45);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasMaxLength(9);
            });

            modelBuilder.Entity<Concesionario>(entity =>
            {
                entity.HasKey(e => e.IdConcesionario)
                    .HasName("PRIMARY");

                entity.ToTable("concesionario");

                entity.Property(e => e.IdConcesionario)
                    .HasColumnName("idConcesionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Jefemecanico>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("jefemecanico");

                entity.HasIndex(e => e.Dni)
                    .HasName("dni_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("idUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apeliidos)
                    .IsRequired()
                    .HasColumnName("apeliidos")
                    .HasMaxLength(45);

                entity.Property(e => e.Clase)
                    .HasColumnName("clase")
                    .HasMaxLength(45);

                entity.Property(e => e.Contrasena)
                    .HasColumnName("contrasena")
                    .HasMaxLength(45);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasColumnName("dni")
                    .HasMaxLength(9);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("fechaAlta")
                    .HasColumnType("date");

                entity.Property(e => e.IdReparacion)
                    .HasColumnName("idReparacion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(45);

                entity.Property(e => e.Seudonimo)
                    .IsRequired()
                    .HasColumnName("seudonimo")
                    .HasMaxLength(45);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasMaxLength(9);
            });

            modelBuilder.Entity<Mecanico>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("mecanico");

                entity.HasIndex(e => e.Dni)
                    .HasName("dni_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("idUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apeliidos)
                    .IsRequired()
                    .HasColumnName("apeliidos")
                    .HasMaxLength(45);

                entity.Property(e => e.Clase)
                    .HasColumnName("clase")
                    .HasMaxLength(45);

                entity.Property(e => e.Contrasena)
                    .HasColumnName("contrasena")
                    .HasMaxLength(45);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasColumnName("dni")
                    .HasMaxLength(9);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("fechaAlta")
                    .HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(45);

                entity.Property(e => e.Seudonimo)
                    .IsRequired()
                    .HasColumnName("seudonimo")
                    .HasMaxLength(45);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasMaxLength(9);

                entity.Property(e => e.Usuariocol)
                    .HasColumnName("usuariocol")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Pieza>(entity =>
            {
                entity.HasKey(e => e.IdPieza)
                    .HasName("PRIMARY");

                entity.ToTable("pieza");

                entity.Property(e => e.IdPieza)
                    .HasColumnName("idPieza")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("fechaAlta")
                    .HasMaxLength(45);

                entity.Property(e => e.Info)
                    .HasColumnName("info")
                    .HasMaxLength(45);

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Propuestas>(entity =>
            {
                entity.HasKey(e => e.Idpropuestas)
                    .HasName("PRIMARY");

                entity.ToTable("propuestas");

                entity.Property(e => e.Idpropuestas)
                    .HasColumnName("idpropuestas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Asientos)
                    .HasColumnName("asientos")
                    .HasMaxLength(45);

                entity.Property(e => e.Marca)
                    .HasColumnName("marca")
                    .HasMaxLength(45);

                entity.Property(e => e.Matricula)
                    .HasColumnName("matricula")
                    .HasMaxLength(45);

                entity.Property(e => e.Modelo)
                    .HasColumnName("modelo")
                    .HasMaxLength(45);

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasMaxLength(45);

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Reparacion>(entity =>
            {
                entity.HasKey(e => e.IdReparacion)
                    .HasName("PRIMARY");

                entity.ToTable("reparacion");

                entity.Property(e => e.IdReparacion)
                    .HasColumnName("idReparacion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaFinalizacion)
                    .HasColumnName("fechaFinalizacion")
                    .HasMaxLength(20);

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fechaInicio")
                    .HasMaxLength(20);

                entity.Property(e => e.FechaReparacion)
                    .HasColumnName("fechaReparacion")
                    .HasMaxLength(20);

                entity.Property(e => e.IdCliente)
                    .HasColumnName("idCliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdJefeMecanico)
                    .HasColumnName("idJefeMecanico")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdVehiculo)
                    .HasColumnName("idVehiculo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Reparacioncol)
                    .HasColumnName("reparacioncol")
                    .HasMaxLength(45);

                entity.Property(e => e.Tiempo).HasColumnName("tiempo");
            });

            modelBuilder.Entity<Trabajodia>(entity =>
            {
                entity.HasKey(e => e.Idtrabajodia)
                    .HasName("PRIMARY");

                entity.ToTable("trabajodia");

                entity.Property(e => e.Idtrabajodia)
                    .HasColumnName("idtrabajodia")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Matricula)
                    .HasColumnName("matricula")
                    .HasMaxLength(45);

                entity.Property(e => e.Mecanico)
                    .HasColumnName("mecanico")
                    .HasMaxLength(45);

                entity.Property(e => e.Presupuesto)
                    .HasColumnName("presupuesto")
                    .HasMaxLength(100);

                entity.Property(e => e.Tiempo)
                    .HasColumnName("tiempo")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.HasIndex(e => e.Dni)
                    .HasName("dni_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("idUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apeliidos)
                    .IsRequired()
                    .HasColumnName("apeliidos")
                    .HasMaxLength(45);

                entity.Property(e => e.Clase)
                    .HasColumnName("clase")
                    .HasMaxLength(45);

                entity.Property(e => e.Contrasena)
                    .HasColumnName("contrasena")
                    .HasMaxLength(45);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasColumnName("dni")
                    .HasMaxLength(9);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("fechaAlta")
                    .HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(45);

                entity.Property(e => e.Seudonimo)
                    .IsRequired()
                    .HasColumnName("seudonimo")
                    .HasMaxLength(45);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasMaxLength(9);

                entity.Property(e => e.Usuariocol)
                    .HasColumnName("usuariocol")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.HasKey(e => e.IdVehiculo)
                    .HasName("PRIMARY");

                entity.ToTable("vehiculo");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("idCliente_idx");

                entity.Property(e => e.IdVehiculo)
                    .HasColumnName("idVehiculo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasMaxLength(45);

                entity.Property(e => e.FechaAlta)
                    .IsRequired()
                    .HasColumnName("fechaAlta")
                    .HasMaxLength(15);

                entity.Property(e => e.IdCliente)
                    .HasColumnName("idCliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdConcesionario)
                    .HasColumnName("idConcesionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("idUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasMaxLength(45);

                entity.Property(e => e.Matricula)
                    .IsRequired()
                    .HasColumnName("matricula")
                    .HasMaxLength(45);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnName("modelo")
                    .HasMaxLength(45);

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasMaxLength(45);

                entity.Property(e => e.TipoVehiculo)
                    .IsRequired()
                    .HasColumnName("tipoVehiculo")
                    .HasMaxLength(45);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Vehiculo)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("idCliente");
            });

            modelBuilder.Entity<Vehiculosvendidos>(entity =>
            {
                entity.HasKey(e => e.Idvehiculosvendidos)
                    .HasName("PRIMARY");

                entity.ToTable("vehiculosvendidos");

                entity.Property(e => e.Idvehiculosvendidos)
                    .HasColumnName("idvehiculosvendidos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Asientos)
                    .HasColumnName("asientos")
                    .HasMaxLength(45);

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(45);

                entity.Property(e => e.Fechabaja)
                    .HasColumnName("fechabaja")
                    .HasMaxLength(45);

                entity.Property(e => e.Marca)
                    .HasColumnName("marca")
                    .HasMaxLength(45);

                entity.Property(e => e.Matricula)
                    .HasColumnName("matricula")
                    .HasMaxLength(45);

                entity.Property(e => e.Modelo)
                    .HasColumnName("modelo")
                    .HasMaxLength(45);

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasMaxLength(45);

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.IdVendedor)
                    .HasName("PRIMARY");

                entity.ToTable("venta");

                entity.Property(e => e.IdVendedor)
                    .HasColumnName("idVendedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaSalida)
                    .HasColumnName("fechaSalida")
                    .HasColumnType("date");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("idCliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpleado)
                    .HasColumnName("idEmpleado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdVehiculo)
                    .HasColumnName("idVehiculo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Matricula)
                    .HasColumnName("matricula")
                    .HasMaxLength(15);

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.Presupuesto)
                    .HasColumnName("presupuesto")
                    .HasMaxLength(45);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
