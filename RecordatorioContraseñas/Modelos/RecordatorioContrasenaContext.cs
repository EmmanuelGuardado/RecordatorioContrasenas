﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RecordatorioContraseñas.Modelos
{
    public partial class RecordatorioContrasenaContext : DbContext
    {
        public RecordatorioContrasenaContext()
        {
        }

        public RecordatorioContrasenaContext(DbContextOptions<RecordatorioContrasenaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cuentas> Cuentas { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
<<<<<<< HEAD
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
=======
>>>>>>> 0f6e00568be5effe1d556f5196c0d9b6ffaacd02
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-AIH501O;Initial Catalog=RecordatorioContrasena;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuentas>(entity =>
            {
                entity.ToTable("cuentas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasColumnName("contrasena")
                    .HasMaxLength(20)
                    .IsUnicode(false);

<<<<<<< HEAD
                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(20)
                    .IsUnicode(false);

=======
>>>>>>> 0f6e00568be5effe1d556f5196c0d9b6ffaacd02
                entity.Property(e => e.FechaModificacion)
                    .HasColumnName("fechaModificacion")
                    .HasColumnType("date");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithMany(p => p.Cuentas)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cuentaa__usuario__4D94879B");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.HasIndex(e => e.Usuario)
                    .HasName("UQ__usuarios__9AFF8FC625D0757F")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasColumnName("activo")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasColumnName("contrasena")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("date");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
