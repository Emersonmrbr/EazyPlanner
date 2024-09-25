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
            builder.Property(p => p.Invoced)
                .HasColumnType("bool");
            builder.Property(p => p.DueDate)
                .HasColumnType("date");
            builder.Property(p => p.EndDate)
                .HasColumnType("date");
            builder.Property(p => p.StartDate)
                .HasColumnType("date");
            builder.Property(p => p.EstimateBillableAmount)
                .HasColumnType("money")
                .HasPrecision(18, 2);
            builder.Property(p => p.EstimateCost)
                .HasColumnType("money")
                .HasPrecision(18, 2);
            builder.Property(p => p.HourlyRate)
                .HasColumnType("money")
                .HasPrecision(18, 2);
            builder.Property(p => p.EstimateHours)
                .HasColumnType("real")
                .HasPrecision(18, 6);
            builder.Property(p => p.HoursLeft)
                .HasColumnType("real")
                .HasPrecision(18, 6);
            builder.Property(p => p.HoursWorked)
                .HasColumnType("real")
                .HasPrecision(18, 6);
            builder.Property(p => p.ProgressStatus)
                .HasColumnType("real")
                .HasPrecision(18, 6);
            builder.Property(p => p.WorkedFromTotal)
                .HasColumnType("real")
                .HasPrecision(18, 6);
            builder.Property(p => p.Priority);

            //Realtionship one-to-many
            builder
                .HasMany(m => m.AssignedTo)
                .WithOne(o => o.Chore)
                .HasForeignKey(fk => fk.ChoreId);


        }
    }
}