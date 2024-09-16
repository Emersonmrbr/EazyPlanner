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
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(p => p.PlannedDate)
                .HasColumnType("date");
            builder.Property(p => p.PlannedAmount)
                .HasColumnType("money")
                .HasPrecision(18, 2);
            builder.Property(p => p.ReceivedDate)
                .HasColumnType("date");
            builder.Property(p => p.ReceivedAmount)
                .HasColumnType("money")
                .HasPrecision(18, 2);

            builder.ComplexProperty(c => c.Create).IsRequired();

            //Realtionship one-to-many
            builder
                .HasOne(o => o.BankrollAccount)
                .WithMany(m => m.FinancialRecords)
                .HasForeignKey(fk => fk.BankrollAccountId);
            builder
                .HasOne(o => o.CostCenter)
                .WithMany(m => m.FinancialRecords)
                .HasForeignKey(fk => fk.CosteCenterId);
            builder
                .HasOne(o => o.CustomerSupplier)
                .WithMany(m => m.FinancialRecords)
                .HasForeignKey(fk => fk.CustomerSupplierId);
            builder
                 .HasOne(o => o.FinanceCategory)
                 .WithMany(m => m.FinancialRecords)
                 .HasForeignKey(fk => fk.FinanceCategoryId);
            builder
                .HasOne(o => o.Invoice)
                .WithMany(m => m.FinancialRecords)
                .HasForeignKey(fk => fk.InvoiceId);
            builder
                .HasOne(o => o.PaymentMethod)
                .WithMany(m => m.FinancialRecords)
                .HasForeignKey(fk => fk.PaymentMethodId);
        }
    }
}
