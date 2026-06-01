using Microsoft.EntityFrameworkCore;
using ShopMvc.Models;

namespace ShopMvc.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ShopMvc;Trusted_Connection=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Mobile" },
                new Category { Id = 2, Name = "Laptop" },
                new Category { Id = 3, Name = "Tablets" },
                new Category { Id = 4, Name = "Cameras" },
                new Category { Id = 5, Name = "Accessories" }

            );
        }
    }
}
