using Hardware4You.Models;
using Microsoft.EntityFrameworkCore;

namespace Hardware4You.Data
{
    public partial class ProductCategoryContext : DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public ProductCategoryContext(DbContextOptions<ProductCategoryContext> options)
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

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("ProductCategory");

                entity.Property(e => e.Id)
                      .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }
    }
}
