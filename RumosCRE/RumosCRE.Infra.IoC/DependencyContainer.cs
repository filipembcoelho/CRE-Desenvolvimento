using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RumosCRE.Application.Interfaces;
using RumosCRE.Domain.Core.Bus;
using RumosCRE.Domain.Core.Events;
using RumosCRE.Domain.Interfaces;
using RumosCRE.Domain.Models;
using RumosCRE.Infra.Bus;
using RumosCRE.Infra.Data.Context;
using RumosCRE.Infra.Data.Repositories;
using RumosCRE.Infra.EventSourceData.Context;
using RumosCRE.Infra.EventSourceData.Repositories;
using RumosCRE.Infra.Security;

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

            // Infra.Bus (MediatR)
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Infra.Data EventSourcing
            services.AddMediatR(typeof(Employee));
            services.AddScoped<IEventStoreRepository, EventStoreRepository>();
            services.AddScoped<IEventStore, EventStore>();

            services.AddScoped<IUserAccessor, UserAccessor>();

        }

        public static void AddDatabaseSetup(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<RumosCreDbContext>();

            services.AddDbContext<RumosCreDbContext>(options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("RumosCreDBConnection"),
                        sqlOptions => sqlOptions.MigrationsHistoryTable("__EFMigrationsHistory_Data"));
                });

            services.AddDbContext<RumosCreEventStoreDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("RumosCreEventStoreDBConnection"));
            });
        }
    }
}
