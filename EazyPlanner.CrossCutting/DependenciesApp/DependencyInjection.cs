using EazyPlanner.Domain.Abstractions;
using EazyPlanner.Infrastructure.Context;
using EazyPlanner.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace EazyPlanner.CrossCutting.DependenciesApp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
     IConfiguration configuration)
        {
            var connectionString = configuration
                                  .GetConnectionString("PostgresString") ?? throw new InvalidOperationException("Connection string 'SystemConnection' not found.");

            services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString));

            services.AddScoped<ICustomerSupplierRepository, CustomerSupplierRepository>();
            //services.AddScoped<ILivroService, LivroService>();

            return services;
        }
    }
}