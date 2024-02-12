using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class CustomerSupplierConfiguration : IEntityTypeConfiguration<CustomerSupplier>
    {
        public void Configure(EntityTypeBuilder<CustomerSupplier> builder)
        {
            builder
                .HasMany(m => m.Peoples)
                .WithOne(o => o.CustomerSupplier)
                .HasForeignKey(fk => fk.CustomerSupplierId);

            builder.ComplexProperty(c => c.Address).IsRequired();
            builder.ComplexProperty(c => c.Create).IsRequired();
            builder.ComplexProperty(c => c.Contact).IsRequired();
        }
    }
}
