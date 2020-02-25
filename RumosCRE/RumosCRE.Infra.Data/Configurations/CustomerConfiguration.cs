using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RumosCRE.Domain.Models;

namespace RumosCRE.Infra.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .ToTable("customers");

            PropertiesSettings(builder);

            RelationsShipsSettings(builder);
        }

        private void PropertiesSettings(EntityTypeBuilder<Customer> builder)
        {

        }

        private void RelationsShipsSettings(EntityTypeBuilder<Customer> builder)
        {

        }
    }

}
