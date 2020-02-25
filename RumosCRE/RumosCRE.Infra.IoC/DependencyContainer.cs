using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RumosCRE.Infra.Data.Context;

namespace RumosCRE.Infra.IoC
{
    public static class DependencyContainer
    {

        public static void RegisterServices(this IServiceCollection services)
        {

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
