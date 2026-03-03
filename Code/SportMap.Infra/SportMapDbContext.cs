using Microsoft.EntityFrameworkCore;
using SportMap.Data;

namespace SportMap.Infra;

public class SportMapDbContext : DbContext
{
    public SportMapDbContext(DbContextOptions<SportMapDbContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; } = default!;
    public DbSet<TodoItem> TodoItems { get; set; } = default!;
}