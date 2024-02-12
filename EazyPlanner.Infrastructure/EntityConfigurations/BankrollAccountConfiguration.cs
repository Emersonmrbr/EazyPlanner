using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class BankrollAccountConfiguration : IEntityTypeConfiguration<BankrollAccount>
    {
        public void Configure(EntityTypeBuilder<BankrollAccount> builder)
        {
            builder.ComplexProperty(c => c!.Create).IsRequired();
        }
    }
}
