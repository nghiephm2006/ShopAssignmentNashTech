using ShopAssignment.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAssignment.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id);

            builder.Property(x => x.OrderDate);

            builder.Property(x => x.CustomerEmail).IsRequired().IsUnicode(false).HasMaxLength(50);

            builder.Property(x => x.CustomerAddress).IsRequired().HasMaxLength(200);


            builder.Property(x => x.CustomerName).IsRequired().HasMaxLength(200);


            builder.Property(x => x.CustomerPhoneNumber).IsRequired().HasMaxLength(200);

        }
    }
}
