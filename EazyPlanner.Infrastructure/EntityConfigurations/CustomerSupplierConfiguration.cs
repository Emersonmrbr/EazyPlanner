using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class CustomerSupplierConfiguration : IEntityTypeConfiguration<CustomerSupplier>
    {
        public void Configure(EntityTypeBuilder<CustomerSupplier> builder)
        {
            builder.HasKey(pk => pk.CustomerSupplierId);
            builder.Property(p => p.CNPJ).HasMaxLength(50).IsRequired();
            builder.Property(p => p.CompanyName).HasMaxLength(100).IsRequired();
            builder.Property(p => p.CompanyFantasy).HasMaxLength(100);
            builder.Property(p => p.ProvinceId).HasMaxLength(30);
            builder.Property(p => p.CityId).HasMaxLength(30);

            builder.ComplexProperty(c => c.Address).IsRequired();
            builder.ComplexProperty(c => c.Create).IsRequired();
            builder.ComplexProperty(c => c.Contact).IsRequired();

            builder
                .HasMany(m => m.Peoples)
                .WithOne(o => o.CustomerSupplier)
                .HasForeignKey(fk => fk.CustomerSupplierId);
        }

    }
}
