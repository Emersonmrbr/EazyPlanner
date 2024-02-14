using EazyPlanner.Domain.Base;

namespace EazyPlanner.Domain.Entities
{
    public class Invoice(int invoiceId,
                   string name,
                   string number,
                   decimal amount,
                   DateTime date,
                   string file)
    {
        public int InvoiceId { get; private set; } = invoiceId;
        public required string Name { get; set; } = name;
        public required string Number { get; set; } = number;
        public required decimal Amount { get; set; } = amount;
        public required DateTime Date { get; set; } = date;
        public required string File { get; set; } = file;
        public CreateBase? Create { get; set; }

        public ICollection<FinancialRecord>? FinancialRecords { get; set; } = new List<FinancialRecord>();
    }
}