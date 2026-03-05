using Microsoft.EntityFrameworkCore;
using WebApplication2_maison_doree.Models;

namespace WebApplication2_maison_doree.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}
