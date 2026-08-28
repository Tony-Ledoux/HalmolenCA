using HalmolenCA.Application.Interfaces;
using HalmolenCA.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HalmolenCA.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HalmolenDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("HalmolenDb")));
        services.AddScoped<IUnitOfWork>(provider => provider.GetRequiredService<HalmolenDbContext>());
        //services.AddScoped<IFacilitiesRepository, FacilitiesRepository>();
        return services;
    }
}
