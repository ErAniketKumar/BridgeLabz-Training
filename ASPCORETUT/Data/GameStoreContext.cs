
using ASPCORETUT.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASPCORETUT.Data;

public class GameStoreContext : DbContext
{
    public GameStoreContext(DbContextOptions<GameStoreContext> options) : base(options)
    {

    }
    public DbSet<Game> Games { get; set; } = null!;
    public DbSet<Genre> Genres { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Genre>().HasData(
            new { Id = 1, Name = "Fightting!" },
            new { Id = 2, Name = "Roleplaying!" },
            new { Id = 3, Name = "ENjoying" },
            new { Id = 4, Name = "Spots" },
            new { Id = 5, Name = "Racing" }
        );
    }
}