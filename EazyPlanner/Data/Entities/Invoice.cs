using EazyPlanner.Data.Bases;

namespace EazyPlanner.Data.Entities
{
    public class Invoice(int id, string name, string number, decimal amount, DateTime date, string file)
    {
        public int Id { get; private set; } = id;
        public string Name { get; set; } = name;
        public string Number { get; set; } = number;
        public decimal Amount { get; set; } = amount;
        public DateTime Date { get; set; } = date;
        public string? File { get; set; } = file;

        public CreateBase? Create { get; set; } = new();

        public ICollection<FinancialRecord>? FinancialRecords { get; set; } = [];
    }
}