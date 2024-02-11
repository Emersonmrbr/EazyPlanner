using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EazyPlanner.Domain.Entities.Base;

namespace EazyPlanner.Domain.Entities
{
    public class Invoice
    {
        public Invoice(int invoiceId,
                       string name,
                       string number,
                       decimal amount,
                       DateTime date,
                       string file,
                       CreateBase? create)
        {
            InvoiceId = invoiceId;
            Name = name;
            Number = number;
            Amount = amount;
            Date = date;
            File = file;
            Create = create;
        }

        public int InvoiceId { get; private set; }
        public required string Name { get; set; }
        public required string Number { get; set; }
        public required decimal Amount { get; set; }
        public required DateTime Date { get; set; }
        public required string File { get; set; }
        public CreateBase? Create { get; set; }
        public int? FinancialRecordId { get; set; }
    }
}