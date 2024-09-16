using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class CostCenterConfiguration : IEntityTypeConfiguration<CostCenter>
    {
        public void Configure(EntityTypeBuilder<CostCenter> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.ComplexProperty(c => c.Create)
                .IsRequired();
        }
    }
}
