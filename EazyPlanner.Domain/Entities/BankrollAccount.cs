using EazyPlanner.Domain.Bases;

namespace EazyPlanner.Domain.Entities
{
    public class BankrollAccount(int id, string name)
    {
        public int Id { get; private set; } = id;
        public string Name { get; set; } = name;
        public CreateBase? Create { get; set; } = new();

        public ICollection<FinancialRecord>? FinancialRecords { get; set; } = [];
    }
}
