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
                                  .GetConnectionString("SqlServerString") ?? throw new InvalidOperationException("Connection string 'SqlServerString' not found.");

            //services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString));
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IBankrollAccountRepository, BankrollAccountRepository>();
            services.AddScoped<IcostCenterRepository, CostCenterRepository>();
            services.AddScoped<ICustomerSupplierRepository, CustomerSupplierRepository>();
            services.AddScoped<IFinanceCategoryRepository, FinanceCategoryRepository>();
            services.AddScoped<IFinanceRecordRepository, FinanceRecordRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            //services.AddScoped<ILivroService, LivroService>();

            return services;
        }
    }
}