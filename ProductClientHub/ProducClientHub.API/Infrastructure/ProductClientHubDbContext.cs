using Microsoft.EntityFrameworkCore;
using ProducClientHub.API.Entities;

namespace ProducClientHub.API.Infrastructure
{
    public class ProductClientHubDbContext : DbContext
    {
        public DbSet<Client> Clients {  get; set; }
        public DbSet<Product> Products {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source =E:\\Git\\ProductClientHub");
        }
    }
}
