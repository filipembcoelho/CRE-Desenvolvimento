﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RumosCRE.Domain.Models;

namespace RumosCRE.Infra.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .ToTable("products");

            PropertiesSettings(builder);

            RelationsShipsSettings(builder);
        }

        private void PropertiesSettings(EntityTypeBuilder<Product> builder)
        {

        }

        private void RelationsShipsSettings(EntityTypeBuilder<Product> builder)
        {

        }
    }
}
