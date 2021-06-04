﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KaynJungle.DAL.Models
{
    public partial class ConcesionarioDBContext : DbContext
    {
        public ConcesionarioDBContext()
        {
        }

        public ConcesionarioDBContext(DbContextOptions<ConcesionarioDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ciclomotor> Ciclomotor { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Coche> Coche { get; set; }
        public virtual DbSet<Concesionario> Concesionario { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<Especialidades> Especialidades { get; set; }
        public virtual DbSet<Jefe> Jefe { get; set; }
        public virtual DbSet<Mecanico> Mecanico { get; set; }
        public virtual DbSet<Motocicleta> Motocicleta { get; set; }
        public virtual DbSet<Propuesta> Propuesta { get; set; }
        public virtual DbSet<Reparacion> Reparacion { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Vehiculo> Vehiculo { get; set; }
        public virtual DbSet<Ventas> Ventas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=testuser;password=P@ssw0rd;database=ConcesionarioDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ciclomotor>(entity =>
            {
                entity.ToTable("ciclomotor");

                entity.HasIndex(e => e.VehiculosIdVehiculo)
                    .HasName("fk_Ciclomotores_Vehículos1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ruedas)
                    .HasColumnName("ruedas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VehiculosIdVehiculo)
                    .HasColumnName("Vehiculos_idVehiculo")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.ToTable("cliente");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("idCliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos")
                    .HasMaxLength(45);

                entity.Property(e => e.CodPostal)
                    .IsRequired()
                    .HasColumnName("codPostal")
                    .HasMaxLength(45);

                entity.Property(e => e.Comunidad)
                    .IsRequired()
                    .HasColumnName("comunidad")
                    .HasMaxLength(45);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion")
                    .HasMaxLength(45);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasColumnName("dni")
                    .HasMaxLength(45);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(45);

                entity.Property(e => e.Localidad)
                    .IsRequired()
                    .HasColumnName("localidad")
                    .HasMaxLength(45);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(45);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasColumnName("pais")
                    .HasMaxLength(45);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Coche>(entity =>
            {
                entity.ToTable("coche");

                entity.HasIndex(e => e.VehiculosIdVehiculo)
                    .HasName("fk_Coche_Vehículos1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Puertas)
                    .HasColumnName("puertas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VehiculosIdVehiculo)
                    .HasColumnName("Vehiculos_idVehiculo")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.VehiculosIdVehiculoNavigation)
                    .WithMany(p => p.Coche)
                    .HasForeignKey(d => d.VehiculosIdVehiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Coche_Vehículos1");
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

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasColumnName("ubicacion")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.HasKey(e => e.Especialidad1)
                    .HasName("PRIMARY");

                entity.ToTable("especialidad");

                entity.Property(e => e.Especialidad1)
                    .HasColumnName("especialidad")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Especialidades>(entity =>
            {
                entity.HasKey(e => new { e.EspecialidadEspecialidad, e.MecánicoIdMecánico })
                    .HasName("PRIMARY");

                entity.ToTable("especialidades");

                entity.HasIndex(e => e.EspecialidadEspecialidad)
                    .HasName("fk_Especialidad_has_Mecánico_Especialidad1_idx");

                entity.HasIndex(e => e.MecánicoIdMecánico)
                    .HasName("fk_Especialidad_has_Mecánico_Mecánico1_idx");

                entity.Property(e => e.EspecialidadEspecialidad)
                    .HasColumnName("Especialidad_especialidad")
                    .HasMaxLength(45);

                entity.Property(e => e.MecánicoIdMecánico)
                    .HasColumnName("Mecánico_idMecánico")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.EspecialidadEspecialidadNavigation)
                    .WithMany(p => p.Especialidades)
                    .HasForeignKey(d => d.EspecialidadEspecialidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Especialidad_has_Mecánico_Especialidad1");

                entity.HasOne(d => d.MecánicoIdMecánicoNavigation)
                    .WithMany(p => p.Especialidades)
                    .HasForeignKey(d => d.MecánicoIdMecánico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Especialidad_has_Mecánico_Mecánico1");
            });

            modelBuilder.Entity<Jefe>(entity =>
            {
                entity.HasKey(e => e.IdJefe)
                    .HasName("PRIMARY");

                entity.ToTable("jefe");

                entity.HasIndex(e => e.UsuarioIdUsuario)
                    .HasName("fk_Jefe_Usuario1_idx");

                entity.Property(e => e.IdJefe)
                    .HasColumnName("idJefe")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsuarioIdUsuario)
                    .HasColumnName("Usuario_idUsuario")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Mecanico>(entity =>
            {
                entity.HasKey(e => e.IdMecánico)
                    .HasName("PRIMARY");

                entity.ToTable("mecanico");

                entity.HasIndex(e => e.UsuarioIdUsuario)
                    .HasName("fk_Mecánico_Usuario1_idx");

                entity.Property(e => e.IdMecánico)
                    .HasColumnName("idMecánico")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jefe)
                    .HasColumnName("jefe")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.UsuarioIdUsuario)
                    .HasColumnName("Usuario_idUsuario")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Motocicleta>(entity =>
            {
                entity.ToTable("motocicleta");

                entity.HasIndex(e => e.VehiculosIdVehiculo)
                    .HasName("fk_Motocicleta_Vehículos1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VehiculosIdVehiculo)
                    .HasColumnName("Vehiculos_idVehiculo")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.VehiculosIdVehiculoNavigation)
                    .WithMany(p => p.Motocicleta)
                    .HasForeignKey(d => d.VehiculosIdVehiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Motocicleta_Vehículos1");
            });

            modelBuilder.Entity<Propuesta>(entity =>
            {
                entity.HasKey(e => e.Idpropuesta)
                    .HasName("PRIMARY");

                entity.ToTable("propuesta");

                entity.HasIndex(e => e.ClienteIdCliente)
                    .HasName("fk_propuesta_Cliente1_idx");

                entity.HasIndex(e => e.VehículosIdVehiculo)
                    .HasName("fk_propuesta_Vehículos1_idx");

                entity.HasIndex(e => e.VentasIdVentas)
                    .HasName("fk_propuesta_Ventas1_idx");

                entity.Property(e => e.Idpropuesta)
                    .HasColumnName("idpropuesta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClienteIdCliente)
                    .HasColumnName("Cliente_idCliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VehículosIdVehiculo)
                    .HasColumnName("Vehículos_idVehiculo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VentasIdVentas)
                    .HasColumnName("Ventas_idVentas")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ClienteIdClienteNavigation)
                    .WithMany(p => p.Propuesta)
                    .HasForeignKey(d => d.ClienteIdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_propuesta_Cliente1");

                entity.HasOne(d => d.VehículosIdVehiculoNavigation)
                    .WithMany(p => p.Propuesta)
                    .HasForeignKey(d => d.VehículosIdVehiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_propuesta_Vehículos1");

                entity.HasOne(d => d.VentasIdVentasNavigation)
                    .WithMany(p => p.Propuesta)
                    .HasForeignKey(d => d.VentasIdVentas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_propuesta_Ventas1");
            });

            modelBuilder.Entity<Reparacion>(entity =>
            {
                entity.HasKey(e => e.IdReparacion)
                    .HasName("PRIMARY");

                entity.ToTable("reparacion");

                entity.HasIndex(e => e.ClienteIdCliente)
                    .HasName("fk_Reparacion_Cliente1_idx");

                entity.HasIndex(e => e.MecánicoIdMecánico)
                    .HasName("fk_Vehículos_has_Mecánico_Mecánico1_idx");

                entity.HasIndex(e => e.VehículosIdVehiculo)
                    .HasName("fk_Reparacion_Vehículos1_idx");

                entity.Property(e => e.IdReparacion)
                    .HasColumnName("idReparacion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClienteIdCliente)
                    .HasColumnName("Cliente_idCliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(200);

                entity.Property(e => e.MecánicoIdMecánico)
                    .HasColumnName("Mecánico_idMecánico")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VehículosIdVehiculo)
                    .HasColumnName("Vehículos_idVehiculo")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ClienteIdClienteNavigation)
                    .WithMany(p => p.Reparacion)
                    .HasForeignKey(d => d.ClienteIdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Reparacion_Cliente1");

                entity.HasOne(d => d.MecánicoIdMecánicoNavigation)
                    .WithMany(p => p.Reparacion)
                    .HasForeignKey(d => d.MecánicoIdMecánico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Vehículos_has_Mecánico_Mecánico1");

                entity.HasOne(d => d.VehículosIdVehiculoNavigation)
                    .WithMany(p => p.ReparacionNavigation)
                    .HasForeignKey(d => d.VehículosIdVehiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Reparacion_Vehículos1");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => new { e.IdUsuario, e.ConcesionarioIdConcesionario })
                    .HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.HasIndex(e => e.ConcesionarioIdConcesionario)
                    .HasName("fk_Usuario_Concesionario1_idx");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("idUsuario")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ConcesionarioIdConcesionario)
                    .HasColumnName("ConcesionarioidConcesionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos")
                    .HasMaxLength(45);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(45);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(45);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(45);

                entity.Property(e => e.Rol)
                    .IsRequired()
                    .HasColumnName("rol")
                    .HasMaxLength(45);

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("user")
                    .HasMaxLength(45);

                entity.HasOne(d => d.ConcesionarioIdConcesionarioNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.ConcesionarioIdConcesionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Usuario_Concesionario1");
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.HasKey(e => e.IdVehiculo)
                    .HasName("PRIMARY");

                entity.ToTable("vehiculo");

                entity.HasIndex(e => e.ClienteIdCliente)
                    .HasName("fk_Vehículos_Cliente1_idx");

                entity.HasIndex(e => e.ConcesionarioIdConcesionario)
                    .HasName("fk_Vehículos_Concesionario1_idx");

                entity.HasIndex(e => e.VentasIdVentas)
                    .HasName("fk_Vehículos_Ventas1_idx");

                entity.Property(e => e.IdVehiculo)
                    .HasColumnName("idVehiculo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClienteIdCliente)
                    .HasColumnName("Cliente_idCliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasMaxLength(45);

                entity.Property(e => e.ConcesionarioIdConcesionario)
                    .HasColumnName("Concesionario_idConcesionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaEntrada)
                    .HasColumnName("fecha_entrada")
                    .HasColumnType("date");

                entity.Property(e => e.FechaSalida)
                    .HasColumnName("fecha_salida")
                    .HasColumnType("date");

                entity.Property(e => e.Marca)
                    .IsRequired()
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
                    .HasColumnType("int(11)");

                entity.Property(e => e.Reparacion)
                    .HasColumnName("reparacion")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Reparado)
                    .HasColumnName("reparado")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(45);

                entity.Property(e => e.Vendido)
                    .HasColumnName("vendido")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Venta)
                    .HasColumnName("venta")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VentasIdVentas)
                    .HasColumnName("Ventas_idVentas")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ClienteIdClienteNavigation)
                    .WithMany(p => p.Vehiculo)
                    .HasForeignKey(d => d.ClienteIdCliente)
                    .HasConstraintName("fk_Vehículos_Cliente1");

                entity.HasOne(d => d.ConcesionarioIdConcesionarioNavigation)
                    .WithMany(p => p.Vehiculo)
                    .HasForeignKey(d => d.ConcesionarioIdConcesionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Vehículos_Concesionario1");

                entity.HasOne(d => d.VentasIdVentasNavigation)
                    .WithMany(p => p.Vehiculo)
                    .HasForeignKey(d => d.VentasIdVentas)
                    .HasConstraintName("fk_Vehículos_Ventas1");
            });

            modelBuilder.Entity<Ventas>(entity =>
            {
                entity.HasKey(e => e.IdVentas)
                    .HasName("PRIMARY");

                entity.ToTable("ventas");

                entity.HasIndex(e => e.UsuarioIdUsuario)
                    .HasName("fk_Ventas_Usuario1_idx");

                entity.Property(e => e.IdVentas)
                    .HasColumnName("idVentas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsuarioIdUsuario)
                    .HasColumnName("Usuario_idUsuario")
                    .HasColumnType("int(11)");
                entity.Property(e => e.ConcesionarioIdConcesionario)
                    .HasColumnName("ConcesionarioIdConcesionario")
                    .HasColumnType("int(11)");
                entity.Property(e => e.Importe)
                    .HasColumnName("Importe")
                    .HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
