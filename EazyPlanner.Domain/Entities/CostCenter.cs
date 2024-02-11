using EazyPlanner.Domain.Entities.Base;

namespace EazyPlanner.Domain.Entities
{
    public class CostCenter
    {
        public CostCenter(int costCenterId,
                          string name,
                          CreateBase create)
        {
            CostCenterId = costCenterId;
            Name = name;
            Create = create;
        }

        public int CostCenterId { get; private set; }
        public required string Name { get; set; } = string.Empty;
        public CreateBase? Create { get; set; }
        public int? FinancialRecordId { get; set; }
    }
}