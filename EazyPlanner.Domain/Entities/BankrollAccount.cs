using EazyPlanner.Domain.Entities.Base;

namespace EazyPlanner.Domain.Entities
{
    public class BankrollAccount
    {
        public BankrollAccount(int bankrollAccountId,
                               string name,
                               CreateBase? create)
        {
            BankrollAccountId = bankrollAccountId;
            Name = name;
            Create = create!;
        }

        public int BankrollAccountId { get; private set; }
        public required string Name { get; set; }
        public CreateBase? Create { get; set; }
        public int? FinancialRecordId { get; set; }
    }
}
