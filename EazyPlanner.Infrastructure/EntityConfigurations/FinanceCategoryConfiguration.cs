using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class FinanceCategoryConfiguration : IEntityTypeConfiguration<FinanceCategory>
    {
        public void Configure(EntityTypeBuilder<FinanceCategory> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Create!.UpdateAt)
                .HasColumnType("date");
            builder.Property(p => p.Create!.CreateAt)
                .HasColumnType("date");
            builder.Property(p => p.Create!.CreatedBy)
                .HasMaxLength(50);
            builder.Property(p => p.Create!.UpdateBy)
                .HasMaxLength(50);

            //Realtionship one-to-many
            builder.HasMany(m => m.FinancialRecords)
                .WithOne(o => o.FinanceCategory)
                .HasForeignKey(fk => fk.FinanceCategoryId);

        }
    }
}
