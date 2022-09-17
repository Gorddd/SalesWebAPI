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
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            var products = new[]
            {
                new Product { Id = 1, Name = "FuckToy", Price = 228 },
                new Product { Id = 2, Name = "shit", Price = 1337 },
                new Product { Id = 3, Name = "Smth", Price = 2344 }
            };

            var saleDatas = new[]
            {
                new SaleData { Id = 1, ProductId = products[0].Id, ProductIdAmount = 228, ProductQuantity = 1, SaleId = 1 },
                new SaleData { Id = 2, ProductId = products[1].Id, ProductIdAmount = 1337, ProductQuantity = 1, SaleId = 2 },
                new SaleData { Id = 3, ProductId = products[2].Id, ProductIdAmount = 2344, ProductQuantity = 1, SaleId = 2 },
            };

            var buyers = new[]
            {
                new Buyer {Id = 1, Name = "Tom"},
                new Buyer {Id = 2, Name = "Jack"}
            };

            var salePoints = new[]
            {
                new SalesPoint {Id = 1, Name = "Eldorado"},
                new SalesPoint {Id = 2, Name = "DnsShop"}
            };

            var sales = new[]
            {
                new Sale {Id = 1, BuyerId = buyers[0].Id, Date = new DateOnly(2020, 5, 12).ToString(), SalesPointId = salePoints[0].Id, Time = new TimeSpan(12, 34, 2).ToString(), TotalAmount = 228 },
                new Sale {Id = 2, BuyerId = buyers[1].Id, Date = new DateOnly(2021, 8, 28).ToString(), SalesPointId = salePoints[1].Id, Time = new TimeSpan(10, 45, 23).ToString(), TotalAmount = 3681}
            };

            var providedProducts = new[]
            {
                new ProvidedProduct {Id = 1, ProductId = products[0].Id, ProductQuantity = 2, SalesPointId = salePoints[0].Id},
                new ProvidedProduct {Id = 2, ProductId = products[1].Id, ProductQuantity = 2, SalesPointId = salePoints[0].Id},
                new ProvidedProduct {Id = 3, ProductId = products[0].Id, ProductQuantity = 2, SalesPointId = salePoints[1].Id},
                new ProvidedProduct {Id = 4, ProductId = products[1].Id, ProductQuantity = 2, SalesPointId = salePoints[1].Id},
            };


            modelBuilder.Entity<Product>().HasData(products);

            modelBuilder.Entity<Sale>().HasData(sales);

            modelBuilder.Entity<Buyer>().HasData(buyers);

            modelBuilder.Entity<SalesPoint>().HasData(salePoints);

            modelBuilder.Entity<SaleData>().HasData(saleDatas);

            modelBuilder.Entity<ProvidedProduct>().HasData(providedProducts);
        }
    }
}
