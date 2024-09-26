using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class PeopleConfiguration : IEntityTypeConfiguration<People>
    {
        public void Configure(EntityTypeBuilder<People> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Birth)
                .HasColumnType("date")
                .IsRequired();
            builder.Property(p => p.Genre)
                .HasMaxLength(20);
            builder.Property(p => p.Create!.UpdateAt)
                .HasColumnType("date");
            builder.Property(p => p.Create!.CreateAt)
                .HasColumnType("date");
            builder.Property(p => p.Create!.CreatedBy)
                .HasMaxLength(50);
            builder.Property(p => p.Create!.UpdateBy)
                .HasMaxLength(50);

            //Realtionship one-to-many
            builder
                .HasMany(m => m.TimeEntries)
                .WithOne(o => o.User)
                .HasForeignKey(fk => fk.UserId);
        }
    }
}