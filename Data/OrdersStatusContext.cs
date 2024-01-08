using Hardware4You.Models;
using Microsoft.EntityFrameworkCore;

namespace Hardware4You.Data
{
    public partial class OrdersStatusContext : DbContext
    {
        public DbSet<OrdersStatus> OrdersStatus { get; set; }

        public OrdersStatusContext()
        {
        }

        public OrdersStatusContext(DbContextOptions<OrdersStatusContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = aspnet - Hardware4You - 33854a21 - 4ec2 - 49a1 - a725 - 3d8e7469f292; Trusted_Connection = True; MultipleActiveResultSets = true");
            }
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrdersStatus>(entity =>
            {
                entity.ToTable("OrdersStatus");

                entity.HasKey(e => e.OrderID);

                // Konfigurationen nach Bedarf einstellen
                entity.Property(e => e.orderStatus).HasMaxLength(255);

                entity.Property(o => o.OrderID)
                    .ValueGeneratedNever();
            });
        }

    }
}
