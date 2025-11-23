using Microsoft.EntityFrameworkCore;
using Studio.Core.Entities;

namespace Studio.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<AudioSample> AudioSamples { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<DeliverableFile> DeliverableFiles { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderFile> OrderFiles { get; set; }
        public DbSet<OrderStatusHistory> OrderStatusHistories { get; set; }
        public DbSet<SystemSetting> SystemSettings { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // קשר בין Order ל-User
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.NoAction); // מונע cascade כפול

            // קשר בין ChatMessage להזמנה
            modelBuilder.Entity<ChatMessage>()
                .HasOne(c => c.Order)
                .WithMany()
                .HasForeignKey(c => c.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // קשר בין ChatMessage לשולח (User)
            modelBuilder.Entity<ChatMessage>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(c => c.SenderId)
                .OnDelete(DeleteBehavior.NoAction);
        }




    }

}