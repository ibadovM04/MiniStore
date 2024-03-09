using Microsoft.EntityFrameworkCore;
using MiniStore.Models;

namespace MiniStore.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Slider> Sliders { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>(entity =>
            {

                entity.Property(p => p.Slogan).IsRequired().HasMaxLength(500);
                entity.Property(p => p.ImageUrl).IsRequired().HasMaxLength(1000);
            });
        }
    }
}
