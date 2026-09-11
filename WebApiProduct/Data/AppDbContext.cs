using Microsoft.EntityFrameworkCore;
using WebApiProduct.Entity;

namespace WebApiProduct.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
    
    public DbSet<Product>  Products => Set<Product>();
}