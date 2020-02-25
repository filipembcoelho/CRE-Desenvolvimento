using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RumosCRE.Domain.Models;

namespace RumosCRE.Infra.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .ToTable("employees");

            PropertiesSettings(builder);

            RelationsShipsSettings(builder);
        }

        private void PropertiesSettings(EntityTypeBuilder<Employee> builder)
        {

        }

        private void RelationsShipsSettings(EntityTypeBuilder<Employee> builder)
        {

        }
    }
}
