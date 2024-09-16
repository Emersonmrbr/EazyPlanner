using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class BankrollAccountConfiguration : IEntityTypeConfiguration<BankrollAccount>
    {
        public void Configure(EntityTypeBuilder<BankrollAccount> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();
            builder.ComplexProperty(c => c!.Create)
                .IsRequired();
        }
    }
}
