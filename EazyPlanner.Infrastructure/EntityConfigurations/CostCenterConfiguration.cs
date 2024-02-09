using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class CostCenterConfiguration : IEntityTypeConfiguration<CostCenter>
    {
        public void Configure(EntityTypeBuilder<CostCenter> builder)
        {
        }
    }
}
