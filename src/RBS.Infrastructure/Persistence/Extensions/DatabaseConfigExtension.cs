using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace RBS.Infrastructure.Extensions;

public static class DatabaseConfigExtension
{
    public static IServiceCollection ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConfiguration")));


        return services;
    }

}