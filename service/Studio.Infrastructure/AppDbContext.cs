
using Microsoft.EntityFrameworkCore;
using Studio.Core.Entities;

namespace Studio.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // 🔹 כאן את מגדירה את כל הטבלאות במסד הנתונים שלך
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<AudioSample> AudioSamples { get; set; }

        // אופציונלי: אם יש לך ישויות נוספות בעתיד
        // public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // קשרים בין טבלאות
            modelBuilder.Entity<Category>()
                .HasMany(c => c.SubCategories)
                .WithOne(s => s.Category)
                .HasForeignKey(s => s.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.AudioSamples)
                .WithOne(a => a.Category)
                .HasForeignKey(a => a.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SubCategory>()
                .HasMany(s => s.AudioSamples)
                .WithOne(a => a.SubCategory)
                .HasForeignKey(a => a.SubCategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
