using ASPCOREWEB.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPCOREWEB.Data
{
    public class AppDbContext: DbContext { 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Books> BooksTable { get; set; }
    }
}



