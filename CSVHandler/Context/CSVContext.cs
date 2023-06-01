using Microsoft.EntityFrameworkCore;

namespace CSVHandler.Context;

public class CSVContext : DbContext
{
    public CSVContext(DbContextOptions<CSVContext> options) : base(options) { }
    public DbSet<UserModel> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
