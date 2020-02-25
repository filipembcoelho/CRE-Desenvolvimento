using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RumosCRE.Domain.Interfaces;
using RumosCRE.Infra.Data.Context;
using RumosCRE.Infra.Data.Repositories;

namespace RumosCRE.Infra.IoC
{
    public static class DependencyContainer
    {

        public static void RegisterServices(this IServiceCollection services)
        {
            // Repositories
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IInvoiceLineRepository, InvoiceLineRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

        }

        public static void AddDatabaseSetup(this IServiceCollection services, IConfiguration configurations)
        {
            services.AddScoped<RumosCreDbContext>();

            services.AddDbContext<RumosCreDbContext>(options =>
                {
                    options.UseSqlServer(configurations.GetConnectionString("RumosCreDBConnection"),
                        sqlOptions => sqlOptions.MigrationsHistoryTable("__EFMigrationsHistory_Data"));
                });
        }
    }
}
