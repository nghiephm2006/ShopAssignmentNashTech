using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopAssignment.Data.Entities;

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
            builder.HasOne(x => x.AppUser).WithMany(x => x.Orders).HasForeignKey(x => x.UserId);
        }
    }
}