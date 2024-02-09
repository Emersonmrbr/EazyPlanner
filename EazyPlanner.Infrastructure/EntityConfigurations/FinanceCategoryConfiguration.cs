using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class FinanceCategoryConfiguration : IEntityTypeConfiguration<FinanceCategory>
    {
        public void Configure(EntityTypeBuilder<FinanceCategory> builder)
        {
        }
    }
}
