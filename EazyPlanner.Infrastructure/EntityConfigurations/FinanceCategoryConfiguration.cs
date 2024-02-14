using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class FinanceCategoryConfiguration : IEntityTypeConfiguration<FinanceCategory>
    {
        public void Configure(EntityTypeBuilder<FinanceCategory> builder)
        {
            builder.HasKey(pk => pk.FinanceCategoryId);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();

            builder.ComplexProperty(c => c.Create).IsRequired();
        }
    }
}
