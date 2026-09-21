using Microsoft.EntityFrameworkCore;

namespace RazorPage1.Data
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(
            DbContextOptions<NorthwindContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Chai",
                    UnitPrice = 18
                },

                new Product
                {
                    ProductId = 2,
                    ProductName = "Chang",
                    UnitPrice = 19
                },

                new Product
                {
                    ProductId = 3,
                    ProductName = "Aniseed Syrup",
                    UnitPrice = 10
                },

                new Product
                {
                    ProductId = 4,
                    ProductName = "Chef Anton's Cajun Seasoning",
                    UnitPrice = 22
                },

                new Product
                {
                    ProductId = 5,
                    ProductName = "Grandma's Boysenberry Spread",
                    UnitPrice = 25
                }
            );
        }
    }
}
