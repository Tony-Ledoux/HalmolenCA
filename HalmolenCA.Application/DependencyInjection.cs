using Microsoft.Extensions.DependencyInjection;

namespace HalmolenCA.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Add application services here
            return services;
        }
    }
}
