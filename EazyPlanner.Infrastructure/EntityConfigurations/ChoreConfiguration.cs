using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class ChoreConfiguration : IEntityTypeConfiguration<Chore>
    {
        public void Configure(EntityTypeBuilder<Chore> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Name)
                .HasMaxLength(100).IsRequired();
            builder.Property(p => p.Number)
                .HasMaxLength(30).IsRequired();
            builder.Property(p => p.Description)
                .HasMaxLength(300);
            builder.Property(p => p.BillingType)
                .IsRequired();
            builder.Property(p => p.Completed)
                .HasColumnType("bool");
        }
    }
}
