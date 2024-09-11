using EazyPlanner.Domain.Base;

namespace EazyPlanner.Domain.Entities
{
    public class CostCenter(int costCenterId,
                      string name)
    {
        public int CostCenterId { get; private set; } = costCenterId;
        public required string Name { get; set; } = name;
        public CreateBase Create { get; set; } = new CreateBase(string.Empty, DateTime.Now, string.Empty, DateTime.Now);

        public ICollection<FinancialRecord>? FinancialRecords { get; private set; } = [];
    }
}