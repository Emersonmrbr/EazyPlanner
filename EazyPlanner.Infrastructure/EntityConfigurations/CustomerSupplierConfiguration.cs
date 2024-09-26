using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EazyPlanner.Infrastructure.EntityConfigurations
{
    public class CustomerSupplierConfiguration : IEntityTypeConfiguration<CustomerSupplier>
    {
        public void Configure(EntityTypeBuilder<CustomerSupplier> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.CNPJ).HasMaxLength(50)
                .IsRequired();
            builder.Property(p => p.CompanyName)
                .HasMaxLength(100).IsRequired();
            builder.Property(p => p.CompanyFantasy)
                .HasMaxLength(100);
            builder.Property(p => p.ProvinceId)
                .HasMaxLength(30);
            builder.Property(p => p.CityId)
                .HasMaxLength(30);
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
                .HasMany(m => m.Peoples)
                .WithOne(o => o.CustomerSupplier)
                .HasForeignKey(fk => fk.CustomerSupplierId);
            builder
                .HasMany(m => m.FinancialRecords)
                .WithOne(o => o.CustomerSupplier)
                .HasForeignKey(fk => fk.CustomerSupplierId);
            builder
                .HasMany(m => m.Projects)
                .WithOne(o => o.CustomerSupplier)
                .HasForeignKey(fk => fk.CustomerSupplierId);
        }

    }
}
