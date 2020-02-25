using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RumosCRE.Domain.Models;

namespace RumosCRE.Infra.Data.Configurations
{
    public class InvoiceLineConfiguration : IEntityTypeConfiguration<InvoiceLine>
    {
        public void Configure(EntityTypeBuilder<InvoiceLine> builder)
        {
            builder
                .ToTable("invoice_lines");

            PropertiesSettings(builder);

            RelationsShipsSettings(builder);
        }

        private void PropertiesSettings(EntityTypeBuilder<InvoiceLine> builder)
        {
            builder
                .Property(il => il.ProductValue)
                .HasColumnType("decimal(18,2)");

            builder
                .Property(il => il.Total)
                .HasColumnType("decimal(18,2)");
        }

        private void RelationsShipsSettings(EntityTypeBuilder<InvoiceLine> builder)
        {

        }
    }
}
