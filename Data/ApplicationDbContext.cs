using Microsoft.EntityFrameworkCore;

namespace ShopMvc.Data
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ShopMvc;Trusted_Connection=True;");

        }
    }
}
