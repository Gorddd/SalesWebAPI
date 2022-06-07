using Microsoft.EntityFrameworkCore;

namespace SalesWebAPI.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Buyer> Buyers { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProvidedProduct> ProvidedProducts { get; set; } = null!;
        public DbSet<Sale> Sales { get; set; } = null!;
        public DbSet<SaleData> SaleDatas { get; set; } = null!;
        public DbSet<SalesPoint> SalesPoints { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Fuck", Price = 228 },
                new Product { Id = 2, Name = "shit", Price = 1337 },
                new Product { Id = 3, Name = "df", Price = 2344 }
                );
        }
    }
}
