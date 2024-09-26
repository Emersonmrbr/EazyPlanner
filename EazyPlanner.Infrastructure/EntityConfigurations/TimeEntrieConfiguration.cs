using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class TimeEntrieConfiguration : IEntityTypeConfiguration<TimeEntrie>
    {
        public void Configure(EntityTypeBuilder<TimeEntrie> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.TimeEntry)
                .IsRequired();
            builder.Property(p => p.Date)
                .HasColumnType("date")
                .IsRequired();
            builder.Property(p => p.EndDate)
                .HasColumnType("date");
            builder.Property(p => p.StartDate)
                .HasColumnType("date");
            builder.Property(p => p.Duration)
                .HasColumnType("real")
                .HasPrecision(18,6);
            builder.Property(p => p.Note)
                .HasMaxLength(300);
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
