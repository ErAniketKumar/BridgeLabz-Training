using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Review_7.Entities;

namespace Review_7.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
