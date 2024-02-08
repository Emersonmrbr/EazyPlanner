using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EazyPlanner.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<BankrollAccount> BankrollAccounts { get; set; }
        public DbSet<CostCenter> CostCenters { get; set; }
        public DbSet<CustomerSupplier> CustomerSupplier { get; set; }
        public DbSet<FinanceCategory> FinanceCategory { get; set; }
        public DbSet<FinancialRecord> FinancialRecord { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<People> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
