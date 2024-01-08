using Hardware4You.Models;
using Microsoft.EntityFrameworkCore;

namespace Hardware4You.Data
{
    public partial class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public ProductContext()
        {
        }

        public ProductContext(DbContextOptions<ProductContext> options)
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

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                // bestehende properties
                entity.Property(e => e.Id).HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Description).IsRequired();

                // aktualisierte properties für Bilder
                entity.Property(e => e.Media).IsRequired();
                entity.Property(e => e.MediaType).IsRequired();

                // andere properties
                entity.Property(e => e.Price);
                entity.Property(e => e.Quantity);
                entity.Property(e => e.CategoryId);
            });

            OnModelCreatingPartial(modelBuilder);
        }
    }
}
