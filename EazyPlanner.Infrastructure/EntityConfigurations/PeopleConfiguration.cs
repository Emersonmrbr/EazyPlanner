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

            builder.ComplexProperty(c => c.Create)
                .IsRequired();
        }
    }
}