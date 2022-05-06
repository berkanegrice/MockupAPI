using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mockup.Application.Interfaces;
using Mockup.Infrastructure.Files;

namespace Mockup.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddTransient<IMethodFactory, Method>();

            return services;
        }
    }
}