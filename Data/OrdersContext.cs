using Hardware4You.Models;
using Microsoft.EntityFrameworkCore;

namespace Hardware4You.Data
{
    public partial class OrdersContext : DbContext
    {
        public DbSet<Orders> orders { get; set; }

        public OrdersContext()
        {
        }

        public OrdersContext(DbContextOptions<OrdersContext> options)
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>(entity =>
            {
                entity.ToTable("Orders");

                entity.HasKey(e => e.OrderID);

                // Konfigurationen nach Bedarf einstellen
                entity.Property(e => e.Status).HasMaxLength(255);
                entity.Property(e => e.cashOnDelivery).HasMaxLength(255);
                entity.Property(e => e.prePayment).HasMaxLength(255);
                entity.Property(e => e.pickCity1).HasMaxLength(255);
                entity.Property(e => e.pickCity2).HasMaxLength(255);
                entity.Property(e => e.Address).HasMaxLength(255);
                entity.Property(e => e.City).HasMaxLength(255);
                entity.Property(e => e.phoneNumber).HasMaxLength(255);
                entity.Property(e => e.fullName).HasMaxLength(255);

                entity.Property(o => o.OrderID)
                    .ValueGeneratedNever();

                entity.OwnsMany(o => o.SelectedProducts, ap =>
                {
                    ap.Property<string>("Name");
                    ap.Property<int>("Price");
                });
            });
        }
    }
}
