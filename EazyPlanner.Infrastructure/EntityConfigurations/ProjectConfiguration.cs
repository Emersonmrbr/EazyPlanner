using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Name)
                .HasMaxLength(100).IsRequired();
            builder.Property(p => p.Number)
                .HasMaxLength(30).IsRequired();
            builder.Property(p => p.Description)
                .HasMaxLength(300);
            builder.Property(p => p.BillingMethod)
                .IsRequired();
            builder.Property(p => p.BillingPriority);
            builder.Property(p => p.EstimatedPrice)
                .HasColumnType("money")
                .HasPrecision(18, 2);
            builder.Property(p => p.UnbilledAr)
                .HasColumnType("money")
                .HasPrecision(18, 2);
            builder.Property(p => p.BudgetHours)
                .HasColumnType("money")
                .HasPrecision(18, 2);
            builder.Property(p => p.HoursWorkedSeconds)
                .HasPrecision(18, 4);
            builder.Property(p => p.Progress)
                .HasPrecision(18, 4);
            builder.Property(p => p.HoursEstimate);
            builder.Property(p => p.HoursBooked)
                .HasPrecision(18, 4);
            builder.Property(p => p.HoursWorked)
                .HasPrecision(18, 4);
            builder.Property(p => p.State)
                .HasMaxLength(20);

            builder.ComplexProperty(c => c.Create).IsRequired();

            //Realtionship one-to-many
            builder
                .HasMany(m => m.InvolvedEmployes)
                .WithOne(o => o.Project)
                .HasForeignKey(fk => fk.ProjectId);
            builder
                .HasMany(m => m.InvolvedGuests)
                .WithOne(o => o.Project)
                .HasForeignKey(fk => fk.ProjectId);
            builder
                .HasMany(m => m.Managers)
                .WithOne(o => o.Project)
                .HasForeignKey(fk => fk.ProjectId);
            builder
                .HasMany(m => m.Members)
                .WithOne(o => o.Project)
                .HasForeignKey(fk => fk.ProjectId);
            builder
                .HasMany(m => m.Chores)
                .WithOne(o => o.Project)
                .HasForeignKey(fk => fk.ProjectId);

        }
    }
}
