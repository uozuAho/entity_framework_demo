using Microsoft.EntityFrameworkCore;

namespace EfDemo.Db
{
    public class EfDemoContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<BoxOffice> BoxOffices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("movies");

                entity.HasKey(e => e.Id).HasName("movies_pkey");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Title)
                    .HasMaxLength(320)
                    .HasColumnName("title");

                entity.Property(e => e.Director)
                    .HasMaxLength(320)
                    .HasColumnName("director");

                entity.Property(e => e.Year)
                    .HasColumnName("year");

                entity.Property(e => e.LengthMinutes)
                    .HasColumnName("length_minutes");
            });

            modelBuilder.Entity<BoxOffice>(entity =>
            {
                entity.ToTable("box_office");

                entity.HasKey(e => e.Id).HasName("box_office_pkey");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");

                entity.Property(e => e.Rating)
                    .HasColumnName("rating");

                entity.Property(e => e.DomesticSales)
                    .HasColumnName("domestic_sales");

                entity.Property(e => e.InternationalSales)
                    .HasColumnName("international_sales");

                entity.HasOne(e => e.Movie)
                    .WithOne(e => e.BoxOffice);
                // .HasForeignKey<Movie>(e => e.Id)
                // .HasConstraintName("fk_movie");
            });
        }
    }
}
