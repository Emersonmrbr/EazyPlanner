using EazyPlanner.Domain.Base;

namespace EazyPlanner.Domain.Entities
{
    public class FinanceCategory(int financeCategoryId,
                           string name)
    {
        public int FinanceCategoryId { get; private set; } = financeCategoryId;
        public required string Name { get; set; } = name;
        public CreateBase? Create { get; set; }

        public ICollection<FinancialRecord>? FinancialRecords { get; private set; }
    }
}