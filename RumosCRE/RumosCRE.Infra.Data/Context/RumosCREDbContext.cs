using Microsoft.EntityFrameworkCore;
using RumosCRE.Domain.Models;

namespace RumosCRE.Infra.Data.Context
{
    public class RumosCreDbContext : DbContext
    {
        public RumosCreDbContext(DbContextOptions<RumosCreDbContext> options) : base(options) { }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceLine> InvoiceLines { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RumosCreDbContext).Assembly);
        }
    }
}
