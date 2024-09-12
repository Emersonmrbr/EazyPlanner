using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Number).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Amount)
                .HasColumnType("money")
                .HasPrecision(18, 2)
                .IsRequired();
            builder.Property(p => p.Date)
                .HasColumnType("date")
                .IsRequired();

            builder.ComplexProperty(c => c.Create)
                .IsRequired();
        }
    }
}
