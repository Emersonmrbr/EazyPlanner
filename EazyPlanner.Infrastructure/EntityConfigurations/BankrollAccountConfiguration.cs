using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class BankrollAccountConfiguration : IEntityTypeConfiguration<BankrollAccount>
    {
        public void Configure(EntityTypeBuilder<BankrollAccount> modelBuilder)
        {
            modelBuilder.ToTable(nameof(BankrollAccount));
            modelBuilder.HasKey(keyExpression: p => p.BankrollAccountId);
            modelBuilder.Property(p => p.Name)
                .HasMaxLength(100)
                .HasColumnType(typeName: "nvarchar");

        }
    }
}
