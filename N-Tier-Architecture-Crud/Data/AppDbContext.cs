using Microsoft.EntityFrameworkCore;
using N_Tier_Architecture_Crud.Entities.Employee;

namespace N_Tier_Architecture_Crud.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
