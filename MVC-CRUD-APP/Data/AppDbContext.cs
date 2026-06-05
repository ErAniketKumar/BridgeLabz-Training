using Microsoft.EntityFrameworkCore;
using MVC_CRUD_APP.Models;

namespace MVC_CRUD_APP.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
