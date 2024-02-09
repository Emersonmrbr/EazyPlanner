using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class CustomerSupplierConfiguration : IEntityTypeConfiguration<CustomerSupplier>
    {
        public void Configure(EntityTypeBuilder<CustomerSupplier> builder)
        {
        }
    }
}
