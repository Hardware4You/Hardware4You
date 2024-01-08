using Hardware4You.Models;
using Microsoft.EntityFrameworkCore;

namespace Hardware4You.Data
{
    public partial class OrderStatusLogContext : DbContext
    {
        public DbSet<OrderStatusLog> OrderStatusLog { get; set; }

        public OrderStatusLogContext()
        {
        }

        public OrderStatusLogContext(DbContextOptions<OrderStatusLogContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-Hardware4You-33854a21-4ec2-49a1-a725-3d8e7469f292;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderStatusLog>(entity =>
            {
                entity.ToTable("OrderStatusLog");

                entity.HasKey(e => e.Id);

                // Konfigurationen nach Bedarf einstellen
                entity.Property(e => e.AdminUsername).HasMaxLength(255);
                entity.Property(e => e.OrderId);
                entity.Property(e => e.NewStatus).HasMaxLength(255);
                entity.Property(e => e.Timestamp);
            });
        }

    }
}
