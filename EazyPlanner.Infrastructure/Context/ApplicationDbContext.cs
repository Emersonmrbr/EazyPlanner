using EazyPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EazyPlanner.Infrastructure.Context
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<BankrollAccount> BankrollAccount { get; set; }
        public DbSet<CostCenter> CostCenter { get; set; }
        public DbSet<CustomerSupplier> CustomerSupplier { get; set; }
        public DbSet<FinanceCategory> FinanceCategory { get; set; }
        public DbSet<FinancialRecord> FinancialRecord { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Chore> Chore { get; set; }
        public DbSet<TimeEntrie> TimeEntrie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
