using Microsoft.EntityFrameworkCore;
using RumosCRE.Domain.Core.Models;

namespace RumosCRE.Infra.EventSourceData.Context
{
    public class RumosCreEventStoreDbContext : DbContext
    {
        public DbSet<StoredEvent> EventStores { get; set; }

        public RumosCreEventStoreDbContext(DbContextOptions<RumosCreEventStoreDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RumosCreEventStoreDbContext).Assembly);
        }
    }
}
