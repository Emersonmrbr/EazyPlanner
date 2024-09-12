using EazyPlanner.Domain.Base;

namespace EazyPlanner.Domain.Entities
{
    public class CostCenter(int id, string name, CreateBase? create, ICollection<FinancialRecord>? financialRecords)
    {
        public int Id { get; private set; } = id;
        public required string Name { get; set; } = name;
        public CreateBase? Create { get; set; } = create;

        public ICollection<FinancialRecord>? FinancialRecords { get; private set; } = financialRecords;
    }
}