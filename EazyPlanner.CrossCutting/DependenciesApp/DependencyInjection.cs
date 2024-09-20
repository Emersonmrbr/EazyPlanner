using EazyPlanner.Domain.Abstractions;
using EazyPlanner.Domain.Entities;
using EazyPlanner.Infrastructure.Context;
using EazyPlanner.Infrastructure.EntityValidation;
using EazyPlanner.Infrastructure.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Morris.Blazor.Validation;


namespace EazyPlanner.CrossCutting.DependenciesApp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
     IConfiguration configuration)
        {
            var connectionString = configuration
                                  .GetConnectionString("SqlServerString") ?? throw new InvalidOperationException("Connection string 'SqlServerString' not found.");

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IBankrollAccountRepository, BankrollAccountRepository>();
            services.AddScoped<IcostCenterRepository, CostCenterRepository>();
            services.AddScoped<ICustomerSupplierRepository, CustomerSupplierRepository>();
            services.AddScoped<IFinanceCategoryRepository, FinanceCategoryRepository>();
            services.AddScoped<IFinanceRecordRepository, FinanceRecordRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IProjectRepository, IProjectRepository>();
            services.AddScoped<IChoreRepository, ChoreRepository>();
            services.AddScoped<ITimeEntrieRepository, TimeEntrieRepository>();
            //services.AddValidatorsFromAssemblyContaining<BankrollAccountValidation>();
            //services.AddValidatorsFromAssemblyContaining<CostCenterValidation>();
            //services.AddValidatorsFromAssemblyContaining<CustomerSupplierValidation>();
            services.AddFormValidation(config => config
                .AddFluentValidation(typeof(ApplicationDbContext).Assembly));
            //.AddFluentValidation(typeof(CostCenterValidation).Assembly)
            //.AddFluentValidation(typeof(CustomerSupplierValidation).Assembly));

            //services.AddScoped<ILivroService, LivroService>();

            return services;
        }
    }
}