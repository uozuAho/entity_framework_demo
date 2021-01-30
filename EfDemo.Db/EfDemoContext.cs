using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EfDemo.Db
{
    public partial class EfDemoContext : DbContext
    {
        public EfDemoContext()
        {
        }

        public EfDemoContext(DbContextOptions<EfDemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BoxOffice> BoxOffices { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=ef-demo-db;User Id=postgres;Password=postgres;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.utf8");

            modelBuilder.Entity<BoxOffice>(entity =>
            {
                entity.ToTable("box_office");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DomesticSales).HasColumnName("domestic_sales");

                entity.Property(e => e.InternationalSales).HasColumnName("international_sales");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.BoxOffices)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("fk_movie");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("movies");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Director)
                    .IsRequired()
                    .HasMaxLength(320)
                    .HasColumnName("director");

                entity.Property(e => e.LengthMinutes).HasColumnName("length_minutes");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(320)
                    .HasColumnName("title");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
