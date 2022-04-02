using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SimpleMove.Models.DB
{
    public partial class ejemploContext : DbContext
    {
        public ejemploContext()
        {
        }

        public ejemploContext(DbContextOptions<ejemploContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ejmplo> Ejmplos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=MAICOL\\SQLEXPRESS; Database=ejemplo; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ejmplo>(entity =>
            {
                entity.HasKey(e => e.Correo);

                entity.ToTable("ejmplo");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Contactos)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contactos");

                entity.Property(e => e.Costo).HasColumnName("costo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
