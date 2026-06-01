using CRUD_APP_DOTNET.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_APP_DOTNET.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

    }
}
