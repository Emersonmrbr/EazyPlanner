using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class FinancialRecordConfiguration : IEntityTypeConfiguration<FinancialRecord>
    {
        public void Configure(EntityTypeBuilder<FinancialRecord> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Description)
                .HasMaxLength(300)
                .IsRequired();
            builder.Property(p => p.RecordType)
                .IsRequired();
            builder.Property(p => p.PlannedDate)
                .HasColumnType("date")
                .IsRequired();
            builder.Property(p => p.PlannedAmount)
                .HasColumnType("money")
                .HasPrecision(18, 2).IsRequired();
            builder.Property(p => p.ReceivedDate)
                .HasColumnType("date").IsRequired();
            builder.Property(p => p.ReceivedAmount)
                .HasColumnType("money").HasPrecision(18, 2)
                .IsRequired();
            builder.Property(p => p.Status);
            builder.Property(p => p.Create!.UpdateAt)
                .HasColumnType("date");  
            builder.Property(p => p.Create!.CreateAt)
                .HasColumnType("date");
            builder.Property(p => p.Create!.CreatedBy)
                .HasMaxLength(50);
            builder.Property(p => p.Create!.UpdateBy)
                .HasMaxLength(50);
        }
    }
}
