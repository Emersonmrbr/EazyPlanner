using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class FinancialRecordConfiguration : IEntityTypeConfiguration<FinancialRecord>
    {
        public void Configure(EntityTypeBuilder<FinancialRecord> builder)
        {
            builder.Property(p => p.Description).HasMaxLength(255).IsRequired();
            builder.Property(p => p.PlannedAmount).HasPrecision(10, 2).IsRequired();
            builder.Property(p => p.ActualAmount).HasPrecision(10, 2);
        }
    }
}
