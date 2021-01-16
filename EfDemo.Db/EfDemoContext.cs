using Microsoft.EntityFrameworkCore;

namespace EfDemo.Db
{
    public class EfDemoContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("movies");

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
        }
    }
}
