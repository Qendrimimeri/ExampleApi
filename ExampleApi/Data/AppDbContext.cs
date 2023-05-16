using ExampleApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExampleApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Teams> Teams { get; set; }
}
