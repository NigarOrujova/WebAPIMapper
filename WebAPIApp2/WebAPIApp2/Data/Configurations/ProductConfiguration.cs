using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApp2.Data.Entities;

namespace WebAPIApp2.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Price).IsRequired().HasDefaultValue(0).HasColumnType("decimal(18,2)");
            builder.Property(p => p.Count).IsRequired().HasDefaultValue(0);
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);
            builder.Property(p => p.CreatedDate).HasDefaultValueSql("GETUTCDATE()");
        }
    }
}
