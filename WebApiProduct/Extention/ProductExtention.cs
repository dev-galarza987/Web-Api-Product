using Microsoft.EntityFrameworkCore;
using WebApiProduct.Data;

namespace WebApiProduct.Extention;

public static class PersistenceExtention
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        return services;
    }
}