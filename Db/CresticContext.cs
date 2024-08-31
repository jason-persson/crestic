using Microsoft.EntityFrameworkCore;

namespace Db;

public class CresticContext : DbContext
{
    public CresticContext(DbContextOptions<CresticContext> options)
        : base(options)
    {
    }

    public DbSet<Log> Logs { get; set; } = null!;
    public DbSet<Run> Runs { get; set; } = null!;
}