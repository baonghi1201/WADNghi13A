using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WADNghi13A.Models
{
    public partial class WADNghi13AContext : DbContext
    {
        public WADNghi13AContext()
        {
        }

        public WADNghi13AContext(DbContextOptions<WADNghi13AContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OneProjectOneWeek> OneProjectOneWeek { get; set; }
        public virtual DbSet<Personnel> Personnel { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=NSUSPECT\\SQLEXPRESS;Database=WADNghi13A;Trusted_Connection=True;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OneProjectOneWeek>(entity =>
            {
                entity.Property(e => e.ArriveDt)
                    .IsRequired()
                    .HasColumnName("ArriveDT")
                    .HasMaxLength(50);

                entity.Property(e => e.DepartureDt)
                    .IsRequired()
                    .HasColumnName("DepartureDT")
                    .HasMaxLength(50);

                entity.Property(e => e.Employee)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OneWeek)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Project)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Personnel>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Dob)
                    .IsRequired()
                    .HasColumnName("DOB")
                    .HasMaxLength(50);

                entity.Property(e => e.FamilyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
